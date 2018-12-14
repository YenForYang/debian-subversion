#!/usr/bin/perl
#
#
# Licensed to the Apache Software Foundation (ASF) under one
# or more contributor license agreements.  See the NOTICE file
# distributed with this work for additional information
# regarding copyright ownership.  The ASF licenses this file
# to you under the Apache License, Version 2.0 (the
# "License"); you may not use this file except in compliance
# with the License.  You may obtain a copy of the License at
#
#   http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing,
# software distributed under the License is distributed on an
# "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
# KIND, either express or implied.  See the License for the
# specific language governing permissions and limitations
# under the License.
#
#

use ExtUtils::MakeMaker;
use Config;
use Cwd 'abs_path';

my $perl_path = $Config{perlpath};
if ($^O ne 'VMS') {
  $perl_path .= $Config{_exe} unless $perl_path =~ m/$Config{_exe}$/i;
}

my $top_builddir = '../../../../..';
my $top_srcdir = '/home/richard/debs/svn/subversion-1.11.0';
my $svnlib_srcdir = "${top_srcdir}/subversion";
my $svnlib_builddir = "${top_builddir}/subversion";
my $swig_srcdir = "${svnlib_srcdir}/bindings/swig";
my $swig_builddir = "${svnlib_builddir}/bindings/swig";

my @modules = qw/client delta fs ra repos wc/;
my @ldpaths = (abs_path($swig_builddir) . "/perl/libsvn_swig_perl/.libs",
               map { abs_path($svnlib_builddir) . "/libsvn_$_/.libs" }
                   @modules, qw/diff subr ra_local ra_svn ra_serf
                                fs_base fs_util fs_fs fs_x/);

my @ldmodules = map {"-lsvn_$_-1"} (@modules, qw/diff subr/);

my $apr_shlib_path_var = 'LD_LIBRARY_PATH';
my $cppflags = <<'EOT';
-Wdate-time -D_FORTIFY_SOURCE=2   -DLINUX -D_REENTRANT -D_GNU_SOURCE -DQT_DBUS_LIB -DQT_GUI_LIB -DQT_CORE_LIB
EOT
my $cflags = <<'EOT';
-DSVN_SQLITE_MIN_VERSION_NUMBER=3008007 -DSVN_SQLITE_MIN_VERSION='"3.8.7"' -g -O2 -fdebug-prefix-map=/home/richard/debs/svn/subversion-1.11.0=. -fstack-protector-strong -Wformat -Werror=format-security -march=native -pipe   -pthread
EOT
my $includes = ' -I/usr/include/apr-1.0   -I/usr/include/apr-1.0 -I/usr/include';

chomp($cppflags);
chomp($cflags);

# Avoid this bug in SWIG:
# https://sourceforge.net/tracker/?func=detail&aid=3571361&group_id=1645&atid=101645
# SWIG is using C++ style comments in an extern "C" code.
$cflags =~ s/-ansi\s+//g;
$cflags =~ s/-std=c89\s+//g;
$cflags =~ s/-Wall//g;
$cflags =~ s/-Wunused//g;
$cflags =~ s/-Wshadow//g;
$cflags =~ s/-Wstrict-prototypes//g;
$cflags =~ s/-Wmissing-declarations//g;
$cflags =~ s/-Wmissing-prototypes//g;
$cflags =~ s/-Wredundant-decls//g;

# According to the log of r7937, the flags guarded by the conditional break
# the build on FreeBSD if not conditionalized.
my $apr_ldflags = '-L/usr/lib/x86_64-linux-gnu -lapr-1'
   if $^O eq 'darwin' or $^O eq 'cygwin';

chomp $apr_shlib_path_var;

my %config = (
    ABSTRACT => 'Perl bindings for Subversion',
    DEFINE => $cppflags,
    CCFLAGS => join(' ', $cflags, $Config{ccflags}),
    INC  => join(' ', $includes, $cppflags,
                 " -I$swig_srcdir/perl/libsvn_swig_perl",
                 " -I$svnlib_srcdir/include",
                 " -I$svnlib_builddir",
                 " -I$swig_srcdir -g"),
    OBJECT => q/$(O_FILES)/,
    LIBS => [join(' ', $apr_ldflags,
                  (map {"-L$_"} @ldpaths),
                  @ldmodules, '-lsvn_swig_perl-1',
                  `$swig -perl -ldflags`)],
    LDFLAGS => join(' ', (map {"-L$_"} @ldpaths), '-Wl,-z,relro -Wl,-z,now -Wl,--as-needed,--gc-sections,--print-gc-sections,--print-memory-usage,--stats     -L/usr/lib/x86_64-linux-gnu -Wl,-E -fstack-protector-strong -L/usr/local/lib -L/usr/lib/x86_64-linux-gnu/perl/5.28/CORE -lperl -ldl -lm -lpthread -lc -lcrypt'),
    LDDLFLAGS => join(' ', (map {"-L$_"} @ldpaths),
                      '-Wl,-z,relro -Wl,-z,now -Wl,--as-needed,--gc-sections,--print-gc-sections,--print-memory-usage,--stats     -L/usr/lib/x86_64-linux-gnu -Wl,-E -fstack-protector-strong -L/usr/local/lib -L/usr/lib/x86_64-linux-gnu/perl/5.28/CORE -lperl -ldl -lm -lpthread -lc -lcrypt', $Config{lddlflags}),
    test => { TESTS => "$swig_srcdir/perl/native/t/*.t" }
);

sub perlish {
    local $_ = $_[0];
    s/^(\w)/\U$1/;
    $_;
}

WriteMakefile(%config, NAME => 'SVN::_Core', C => ['core.c'],
        PM => {map { ("$swig_srcdir/perl/native/$_.pm" =>
                      "\$(INST_LIBDIR)/$_.pm") }
         map { perlish $_ }
         ('base', 'core', @modules)},
        MAN3PODS => {map { ("$swig_srcdir/perl/native/$_.pm" =>
                            "\$(INST_MAN3DIR)/SVN::$_.\$(MAN3EXT)") }
         map { perlish $_ }
         ('base', 'core', @modules)},
        clean => { FILES => "*.bs".
                         join(' Makefile.','',@modules) }
       );

for (@modules) {
    WriteMakefile(%config,
      MAKEFILE=> "Makefile.$_",
      NAME    => "SVN::_".perlish($_),
      C => ["svn_$_.c"],
     );
}

# the dependencies need to be fixed

sub MY::postamble {
    my $module_c_files = join(' ',map { "svn_$_.c"} @modules);
    my $module_make_commands = join('',map {"\t\$(MAKE) -f Makefile.$_\n"} @modules);

    my $fullperlrun = "$apr_shlib_path_var=" .
                      join(':', "\$($apr_shlib_path_var)", @ldpaths);

   return <<"EOPOST";
all :: modules
test :: modules
install :: modules

par :: all
\t$perl_path -MPAR::Dist -e"blip_to_par(name=>'SVN",version=>'`$perl_path -Mblib -MSVN::Core -e 'print $SVN::Core::VERSION'`')"

modules :: $module_c_files
$module_make_commands\t\$(NOECHO) \$(TOUCH) \$\@

FULLPERLRUN=$fullperlrun \$(FULLPERL)

update_test_counts ::
\tfor test_file in \$(TEST_FILES); do \$(PERL) -MTest::Count::FileMutator::ByFileType::App -e 'run()' \$\$test_file; done

EOPOST

}
