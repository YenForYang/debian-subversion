# This Makefile is for the SVN::_Fs extension to perl.
#
# It was generated automatically by MakeMaker version
# 7.34 (Revision: 73400) from the contents of
# Makefile.PL. Don't edit this file, edit Makefile.PL instead.
#
#       ANY CHANGES MADE HERE WILL BE LOST!
#
#   MakeMaker ARGV: (q[PREFIX=/usr])
#

#   MakeMaker Parameters:

#     ABSTRACT => q[Perl bindings for Subversion]
#     BUILD_REQUIRES => {  }
#     C => [q[svn_fs.c]]
#     CCFLAGS => q[-DSVN_SQLITE_MIN_VERSION_NUMBER=3008007 -DSVN_SQLITE_MIN_VERSION='"3.8.7"' -g -O2 -fdebug-prefix-map=/home/richard/debs/svn/subversion-1.11.0=. -fstack-protector-strong -Wformat -Werror=format-security -march=native -pipe   -pthread -D_REENTRANT -D_GNU_SOURCE -DDEBIAN -fwrapv -fno-strict-aliasing -pipe -I/usr/local/include -D_LARGEFILE_SOURCE -D_FILE_OFFSET_BITS=64]
#     CONFIGURE_REQUIRES => {  }
#     DEFINE => q[-Wdate-time -D_FORTIFY_SOURCE=2   -DLINUX -D_REENTRANT -D_GNU_SOURCE -DQT_DBUS_LIB -DQT_GUI_LIB -DQT_CORE_LIB]
#     INC => q[ -I/usr/include/apr-1.0   -I/usr/include/apr-1.0 -I/usr/include -Wdate-time -D_FORTIFY_SOURCE=2   -DLINUX -D_REENTRANT -D_GNU_SOURCE -DQT_DBUS_LIB -DQT_GUI_LIB -DQT_CORE_LIB  -I/home/richard/debs/svn/subversion-1.11.0/subversion/bindings/swig/perl/libsvn_swig_perl  -I/home/richard/debs/svn/subversion-1.11.0/subversion/include  -I../../../../../subversion  -I/home/richard/debs/svn/subversion-1.11.0/subversion/bindings/swig -g]
#     LDDLFLAGS => q[-L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/bindings/swig/perl/libsvn_swig_perl/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_client/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_delta/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_repos/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_wc/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_diff/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_subr/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_local/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_svn/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_serf/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_base/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_util/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_fs/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_x/.libs -Wl,-z,relro -Wl,-z,now -Wl,--as-needed,--gc-sections,--print-gc-sections,--print-memory-usage,--stats     -L/usr/lib/x86_64-linux-gnu -Wl,-E -fstack-protector-strong -L/usr/local/lib -L/usr/lib/x86_64-linux-gnu/perl/5.28/CORE -lperl -ldl -lm -lpthread -lc -lcrypt -shared -L/usr/local/lib -fstack-protector-strong]
#     LDFLAGS => q[-L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/bindings/swig/perl/libsvn_swig_perl/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_client/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_delta/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_repos/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_wc/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_diff/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_subr/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_local/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_svn/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_serf/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_base/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_util/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_fs/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_x/.libs -Wl,-z,relro -Wl,-z,now -Wl,--as-needed,--gc-sections,--print-gc-sections,--print-memory-usage,--stats     -L/usr/lib/x86_64-linux-gnu -Wl,-E -fstack-protector-strong -L/usr/local/lib -L/usr/lib/x86_64-linux-gnu/perl/5.28/CORE -lperl -ldl -lm -lpthread -lc -lcrypt]
#     LIBS => [q[-L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/bindings/swig/perl/libsvn_swig_perl/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_client/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_delta/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_repos/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_wc/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_diff/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_subr/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_local/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_svn/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_serf/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_base/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_util/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_fs/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_x/.libs -lsvn_client-1 -lsvn_delta-1 -lsvn_fs-1 -lsvn_ra-1 -lsvn_repos-1 -lsvn_wc-1 -lsvn_diff-1 -lsvn_subr-1 -lsvn_swig_perl-1]]
#     MAKEFILE => q[Makefile.fs]
#     NAME => q[SVN::_Fs]
#     OBJECT => q[$(O_FILES)]
#     PREREQ_PM => {  }
#     TEST_REQUIRES => {  }
#     test => { TESTS=>q[/home/richard/debs/svn/subversion-1.11.0/subversion/bindings/swig/perl/native/t/*.t] }

# --- MakeMaker post_initialize section:


# --- MakeMaker const_config section:

# These definitions are from config.sh (via /usr/lib/x86_64-linux-gnu/perl/5.28/Config.pm).
# They may have been overridden via Makefile.PL or on the command line.
AR = ar
CC = icc
CCCDLFLAGS = -fPIC
CCDLFLAGS = -Wl,-E
DLEXT = so
DLSRC = dl_dlopen.xs
EXE_EXT = 
FULL_AR = /usr/bin/ar
LD = icc
LDDLFLAGS = -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/bindings/swig/perl/libsvn_swig_perl/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_client/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_delta/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_repos/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_wc/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_diff/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_subr/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_local/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_svn/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_serf/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_base/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_util/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_fs/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_x/.libs -Wl,-z,relro -Wl,-z,now -Wl,--as-needed,--gc-sections,--print-gc-sections,--print-memory-usage,--stats     -L/usr/lib/x86_64-linux-gnu -Wl,-E -fstack-protector-strong -L/usr/local/lib -L/usr/lib/x86_64-linux-gnu/perl/5.28/CORE -lperl -ldl -lm -lpthread -lc -lcrypt -shared -L/usr/local/lib -fstack-protector-strong
LDFLAGS = -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/bindings/swig/perl/libsvn_swig_perl/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_client/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_delta/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_repos/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_wc/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_diff/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_subr/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_local/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_svn/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_serf/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_base/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_util/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_fs/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_x/.libs -Wl,-z,relro -Wl,-z,now -Wl,--as-needed,--gc-sections,--print-gc-sections,--print-memory-usage,--stats     -L/usr/lib/x86_64-linux-gnu -Wl,-E -fstack-protector-strong -L/usr/local/lib -L/usr/lib/x86_64-linux-gnu/perl/5.28/CORE -lperl -ldl -lm -lpthread -lc -lcrypt
LIBC = libc-2.27.so
LIB_EXT = .a
OBJ_EXT = .o
OSNAME = linux
OSVERS = 4.9.0
RANLIB = :
SITELIBEXP = /usr/local/share/perl/5.28.1
SITEARCHEXP = /usr/local/lib/x86_64-linux-gnu/perl/5.28.1
SO = so
VENDORARCHEXP = /usr/lib/x86_64-linux-gnu/perl5/5.28
VENDORLIBEXP = /usr/share/perl5


# --- MakeMaker constants section:
AR_STATIC_ARGS = cr
DIRFILESEP = /
DFSEP = $(DIRFILESEP)
NAME = SVN::_Fs
NAME_SYM = SVN__Fs
VERSION = 
VERSION_MACRO = VERSION
VERSION_SYM = 
DEFINE_VERSION = -D$(VERSION_MACRO)=\"$(VERSION)\"
XS_VERSION = 
XS_VERSION_MACRO = XS_VERSION
XS_DEFINE_VERSION = -D$(XS_VERSION_MACRO)=\"$(XS_VERSION)\"
INST_ARCHLIB = blib/arch
INST_SCRIPT = blib/script
INST_BIN = blib/bin
INST_LIB = blib/lib
INST_MAN1DIR = blib/man1
INST_MAN3DIR = blib/man3
MAN1EXT = 1p
MAN3EXT = 3pm
INSTALLDIRS = site
DESTDIR = 
PREFIX = /usr
PERLPREFIX = $(PREFIX)
SITEPREFIX = $(PREFIX)
VENDORPREFIX = $(PREFIX)
INSTALLPRIVLIB = $(PERLPREFIX)/share/perl/5.28
DESTINSTALLPRIVLIB = $(DESTDIR)$(INSTALLPRIVLIB)
INSTALLSITELIB = $(SITEPREFIX)/share/perl/5.28.1
DESTINSTALLSITELIB = $(DESTDIR)$(INSTALLSITELIB)
INSTALLVENDORLIB = $(VENDORPREFIX)/share/perl5
DESTINSTALLVENDORLIB = $(DESTDIR)$(INSTALLVENDORLIB)
INSTALLARCHLIB = $(PERLPREFIX)/lib/x86_64-linux-gnu/perl/5.28
DESTINSTALLARCHLIB = $(DESTDIR)$(INSTALLARCHLIB)
INSTALLSITEARCH = $(SITEPREFIX)/lib/x86_64-linux-gnu/perl/5.28.1
DESTINSTALLSITEARCH = $(DESTDIR)$(INSTALLSITEARCH)
INSTALLVENDORARCH = $(VENDORPREFIX)/lib/x86_64-linux-gnu/perl5/5.28
DESTINSTALLVENDORARCH = $(DESTDIR)$(INSTALLVENDORARCH)
INSTALLBIN = $(PERLPREFIX)/bin
DESTINSTALLBIN = $(DESTDIR)$(INSTALLBIN)
INSTALLSITEBIN = $(SITEPREFIX)/bin
DESTINSTALLSITEBIN = $(DESTDIR)$(INSTALLSITEBIN)
INSTALLVENDORBIN = $(VENDORPREFIX)/bin
DESTINSTALLVENDORBIN = $(DESTDIR)$(INSTALLVENDORBIN)
INSTALLSCRIPT = $(PERLPREFIX)/bin
DESTINSTALLSCRIPT = $(DESTDIR)$(INSTALLSCRIPT)
INSTALLSITESCRIPT = $(SITEPREFIX)/bin
DESTINSTALLSITESCRIPT = $(DESTDIR)$(INSTALLSITESCRIPT)
INSTALLVENDORSCRIPT = $(VENDORPREFIX)/bin
DESTINSTALLVENDORSCRIPT = $(DESTDIR)$(INSTALLVENDORSCRIPT)
INSTALLMAN1DIR = $(PERLPREFIX)/share/man/man1
DESTINSTALLMAN1DIR = $(DESTDIR)$(INSTALLMAN1DIR)
INSTALLSITEMAN1DIR = $(SITEPREFIX)/man/man1
DESTINSTALLSITEMAN1DIR = $(DESTDIR)$(INSTALLSITEMAN1DIR)
INSTALLVENDORMAN1DIR = $(VENDORPREFIX)/share/man/man1
DESTINSTALLVENDORMAN1DIR = $(DESTDIR)$(INSTALLVENDORMAN1DIR)
INSTALLMAN3DIR = $(PERLPREFIX)/share/man/man3
DESTINSTALLMAN3DIR = $(DESTDIR)$(INSTALLMAN3DIR)
INSTALLSITEMAN3DIR = $(SITEPREFIX)/man/man3
DESTINSTALLSITEMAN3DIR = $(DESTDIR)$(INSTALLSITEMAN3DIR)
INSTALLVENDORMAN3DIR = $(VENDORPREFIX)/share/man/man3
DESTINSTALLVENDORMAN3DIR = $(DESTDIR)$(INSTALLVENDORMAN3DIR)
PERL_LIB = /usr/share/perl/5.28
PERL_ARCHLIB = /usr/lib/x86_64-linux-gnu/perl/5.28
PERL_ARCHLIBDEP = /usr/lib/x86_64-linux-gnu/perl/5.28
LIBPERL_A = libperl.a
FIRST_MAKEFILE = Makefile.fs
MAKEFILE_OLD = Makefile.fs.old
MAKE_APERL_FILE = Makefile.fs.aperl
PERLMAINCC = $(CC)
PERL_INC = /usr/lib/x86_64-linux-gnu/perl/5.28/CORE
PERL_INCDEP = /usr/lib/x86_64-linux-gnu/perl/5.28/CORE
PERL = "/usr/bin/perl"
FULLPERL = "/usr/bin/perl"
ABSPERL = $(PERL)
PERLRUN = $(PERL)
FULLPERLRUN = $(FULLPERL)
ABSPERLRUN = $(ABSPERL)
PERLRUNINST = $(PERLRUN) "-I$(INST_ARCHLIB)" "-I$(INST_LIB)"
FULLPERLRUNINST = $(FULLPERLRUN) "-I$(INST_ARCHLIB)" "-I$(INST_LIB)"
ABSPERLRUNINST = $(ABSPERLRUN) "-I$(INST_ARCHLIB)" "-I$(INST_LIB)"
PERL_CORE = 0
PERM_DIR = 755
PERM_RW = 644
PERM_RWX = 755

MAKEMAKER   = /usr/share/perl/5.28/ExtUtils/MakeMaker.pm
MM_VERSION  = 7.34
MM_REVISION = 73400

# FULLEXT = Pathname for extension directory (eg Foo/Bar/Oracle).
# BASEEXT = Basename part of FULLEXT. May be just equal FULLEXT. (eg Oracle)
# PARENT_NAME = NAME without BASEEXT and no trailing :: (eg Foo::Bar)
# DLBASE  = Basename part of dynamic library. May be just equal BASEEXT.
MAKE = make
FULLEXT = SVN/_Fs
BASEEXT = _Fs
PARENT_NAME = SVN
DLBASE = $(BASEEXT)
VERSION_FROM = 
INC =  -I/usr/include/apr-1.0   -I/usr/include/apr-1.0 -I/usr/include -Wdate-time -D_FORTIFY_SOURCE=2   -DLINUX -D_REENTRANT -D_GNU_SOURCE -DQT_DBUS_LIB -DQT_GUI_LIB -DQT_CORE_LIB  -I/home/richard/debs/svn/subversion-1.11.0/subversion/bindings/swig/perl/libsvn_swig_perl  -I/home/richard/debs/svn/subversion-1.11.0/subversion/include  -I../../../../../subversion  -I/home/richard/debs/svn/subversion-1.11.0/subversion/bindings/swig -g
DEFINE = -Wdate-time -D_FORTIFY_SOURCE=2   -DLINUX -D_REENTRANT -D_GNU_SOURCE -DQT_DBUS_LIB -DQT_GUI_LIB -DQT_CORE_LIB
OBJECT = $(O_FILES)
LDFROM = $(OBJECT)
LINKTYPE = dynamic
BOOTDEP = 

# Handy lists of source code files:
XS_FILES = 
C_FILES  = svn_fs.c
O_FILES  = svn_fs.o
H_FILES  = 
MAN1PODS = 
MAN3PODS = 

# Where is the Config information that we are using/depend on
CONFIGDEP = $(PERL_ARCHLIBDEP)$(DFSEP)Config.pm $(PERL_INCDEP)$(DFSEP)config.h

# Where to build things
INST_LIBDIR      = $(INST_LIB)/SVN
INST_ARCHLIBDIR  = $(INST_ARCHLIB)/SVN

INST_AUTODIR     = $(INST_LIB)/auto/$(FULLEXT)
INST_ARCHAUTODIR = $(INST_ARCHLIB)/auto/$(FULLEXT)

INST_STATIC      = $(INST_ARCHAUTODIR)/$(BASEEXT)$(LIB_EXT)
INST_DYNAMIC     = $(INST_ARCHAUTODIR)/$(DLBASE).$(DLEXT)
INST_BOOT        = $(INST_ARCHAUTODIR)/$(BASEEXT).bs

# Extra linker info
EXPORT_LIST        = 
PERL_ARCHIVE       = 
PERL_ARCHIVEDEP    = 
PERL_ARCHIVE_AFTER = 


TO_INST_PM = 


# --- MakeMaker platform_constants section:
MM_Unix_VERSION = 7.34
PERL_MALLOC_DEF = -DPERL_EXTMALLOC_DEF -Dmalloc=Perl_malloc -Dfree=Perl_mfree -Drealloc=Perl_realloc -Dcalloc=Perl_calloc


# --- MakeMaker tool_autosplit section:
# Usage: $(AUTOSPLITFILE) FileToSplit AutoDirToSplitInto
AUTOSPLITFILE = $(ABSPERLRUN)  -e 'use AutoSplit;  autosplit($$$$ARGV[0], $$$$ARGV[1], 0, 1, 1)' --



# --- MakeMaker tool_xsubpp section:

XSUBPPDIR = /usr/share/perl/5.28/ExtUtils
XSUBPP = "$(XSUBPPDIR)$(DFSEP)xsubpp"
XSUBPPRUN = $(PERLRUN) $(XSUBPP)
XSPROTOARG = 
XSUBPPDEPS = /usr/share/perl/5.28/ExtUtils/typemap /usr/share/perl/5.28/ExtUtils$(DFSEP)xsubpp
XSUBPPARGS = -typemap '/usr/share/perl/5.28/ExtUtils/typemap'
XSUBPP_EXTRA_ARGS =


# --- MakeMaker tools_other section:
SHELL = /bin/sh
CHMOD = chmod
CP = cp
MV = mv
NOOP = $(TRUE)
NOECHO = @
RM_F = rm -f
RM_RF = rm -rf
TEST_F = test -f
TOUCH = touch
UMASK_NULL = umask 0
DEV_NULL = > /dev/null 2>&1
MKPATH = $(ABSPERLRUN) -MExtUtils::Command -e 'mkpath' --
EQUALIZE_TIMESTAMP = $(ABSPERLRUN) -MExtUtils::Command -e 'eqtime' --
FALSE = false
TRUE = true
ECHO = echo
ECHO_N = echo -n
UNINST = 0
VERBINST = 0
MOD_INSTALL = $(ABSPERLRUN) -MExtUtils::Install -e 'install([ from_to => {@ARGV}, verbose => '\''$(VERBINST)'\'', uninstall_shadows => '\''$(UNINST)'\'', dir_mode => '\''$(PERM_DIR)'\'' ]);' --
DOC_INSTALL = $(ABSPERLRUN) -MExtUtils::Command::MM -e 'perllocal_install' --
UNINSTALL = $(ABSPERLRUN) -MExtUtils::Command::MM -e 'uninstall' --
WARN_IF_OLD_PACKLIST = $(ABSPERLRUN) -MExtUtils::Command::MM -e 'warn_if_old_packlist' --
MACROSTART = 
MACROEND = 
USEMAKEFILE = -f
FIXIN = $(ABSPERLRUN) -MExtUtils::MY -e 'MY->fixin(shift)' --
CP_NONEMPTY = $(ABSPERLRUN) -MExtUtils::Command::MM -e 'cp_nonempty' --


# --- MakeMaker makemakerdflt section:
makemakerdflt : all
	$(NOECHO) $(NOOP)


# --- MakeMaker dist section:
TAR = tar
TARFLAGS = cvf
ZIP = zip
ZIPFLAGS = -r
COMPRESS = gzip --best
SUFFIX = .gz
SHAR = shar
PREOP = $(NOECHO) $(NOOP)
POSTOP = $(NOECHO) $(NOOP)
TO_UNIX = $(NOECHO) $(NOOP)
CI = ci -u
RCS_LABEL = rcs -Nv$(VERSION_SYM): -q
DIST_CP = best
DIST_DEFAULT = tardist
DISTNAME = SVN-_Fs
DISTVNAME = SVN-_Fs-


# --- MakeMaker macro section:


# --- MakeMaker depend section:


# --- MakeMaker cflags section:

CCFLAGS = -DSVN_SQLITE_MIN_VERSION_NUMBER=3008007 -DSVN_SQLITE_MIN_VERSION='"3.8.7"' -g -O2 -fdebug-prefix-map=/home/richard/debs/svn/subversion-1.11.0=. -fstack-protector-strong -Wformat -Werror=format-security -march=native -pipe   -pthread -D_REENTRANT -D_GNU_SOURCE -DDEBIAN -fwrapv -fno-strict-aliasing -pipe -I/usr/local/include -D_LARGEFILE_SOURCE -D_FILE_OFFSET_BITS=64
OPTIMIZE = -O2 -g
PERLTYPE = 
MPOLLUTE = 


# --- MakeMaker const_loadlibs section:

# SVN::_Fs might depend on some other libraries:
# See ExtUtils::Liblist for details
#
EXTRALIBS = -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/bindings/swig/perl/libsvn_swig_perl/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_client/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_delta/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_repos/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_wc/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_diff/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_subr/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_local/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_svn/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_serf/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_base/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_util/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_fs/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_x/.libs -lsvn_client-1 -lsvn_delta-1 -lsvn_fs-1 -lsvn_ra-1 -lsvn_repos-1 -lsvn_wc-1 -lsvn_diff-1 -lsvn_subr-1 -lsvn_swig_perl-1
LDLOADLIBS = -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/bindings/swig/perl/libsvn_swig_perl/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_client/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_delta/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_repos/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_wc/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_diff/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_subr/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_local/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_svn/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra_serf/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_base/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_util/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_fs/.libs -L/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs_x/.libs -lsvn_client-1 -lsvn_delta-1 -lsvn_fs-1 -lsvn_ra-1 -lsvn_repos-1 -lsvn_wc-1 -lsvn_diff-1 -lsvn_subr-1 -lsvn_swig_perl-1
BSLOADLIBS = 
LD_RUN_PATH = /home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_client/.libs:/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_delta/.libs:/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_fs/.libs:/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_ra/.libs:/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_repos/.libs:/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_wc/.libs:/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_diff/.libs:/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/libsvn_subr/.libs:/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/bindings/swig/perl/libsvn_swig_perl/.libs


# --- MakeMaker const_cccmd section:
CCCMD = $(CC) -c $(PASTHRU_INC) $(INC) \
	$(CCFLAGS) $(OPTIMIZE) \
	$(PERLTYPE) $(MPOLLUTE) $(DEFINE_VERSION) \
	$(XS_DEFINE_VERSION)

# --- MakeMaker post_constants section:


# --- MakeMaker pasthru section:

PASTHRU = LIBPERL_A="$(LIBPERL_A)"\
	LINKTYPE="$(LINKTYPE)"\
	OPTIMIZE="$(OPTIMIZE)"\
	LD="$(LD)"\
	PREFIX="$(PREFIX)"\
	PASTHRU_DEFINE='-Wdate-time -D_FORTIFY_SOURCE=2   -DLINUX -D_REENTRANT -D_GNU_SOURCE -DQT_DBUS_LIB -DQT_GUI_LIB -DQT_CORE_LIB $(PASTHRU_DEFINE)'\
	PASTHRU_INC=' -I/usr/include/apr-1.0   -I/usr/include/apr-1.0 -I/usr/include -Wdate-time -D_FORTIFY_SOURCE=2   -DLINUX -D_REENTRANT -D_GNU_SOURCE -DQT_DBUS_LIB -DQT_GUI_LIB -DQT_CORE_LIB  -I/home/richard/debs/svn/subversion-1.11.0/subversion/bindings/swig/perl/libsvn_swig_perl  -I/home/richard/debs/svn/subversion-1.11.0/subversion/include  -I../../../../../subversion  -I/home/richard/debs/svn/subversion-1.11.0/subversion/bindings/swig -g $(PASTHRU_INC)'


# --- MakeMaker special_targets section:
.SUFFIXES : .xs .c .C .cpp .i .s .cxx .cc $(OBJ_EXT)

.PHONY: all config static dynamic test linkext manifest blibdirs clean realclean disttest distdir pure_all subdirs clean_subdirs makemakerdflt manifypods realclean_subdirs subdirs_dynamic subdirs_pure_nolink subdirs_static subdirs-test_dynamic subdirs-test_static test_dynamic test_static



# --- MakeMaker c_o section:

.c.i:
	icc  -E -c $(PASTHRU_INC) $(INC) \
	$(CCFLAGS) $(OPTIMIZE) \
	$(PERLTYPE) $(MPOLLUTE) $(DEFINE_VERSION) \
	$(XS_DEFINE_VERSION) $(CCCDLFLAGS) "-I$(PERL_INC)" $(PASTHRU_DEFINE) $(DEFINE) $*.c > $*.i

.c.s :
	$(CCCMD) -S $(CCCDLFLAGS) "-I$(PERL_INC)" $(PASTHRU_DEFINE) $(DEFINE) $*.c 

.c$(OBJ_EXT) :
	$(CCCMD) $(CCCDLFLAGS) "-I$(PERL_INC)" $(PASTHRU_DEFINE) $(DEFINE) $*.c

.cpp$(OBJ_EXT) :
	$(CCCMD) $(CCCDLFLAGS) "-I$(PERL_INC)" $(PASTHRU_DEFINE) $(DEFINE) $*.cpp

.cxx$(OBJ_EXT) :
	$(CCCMD) $(CCCDLFLAGS) "-I$(PERL_INC)" $(PASTHRU_DEFINE) $(DEFINE) $*.cxx

.cc$(OBJ_EXT) :
	$(CCCMD) $(CCCDLFLAGS) "-I$(PERL_INC)" $(PASTHRU_DEFINE) $(DEFINE) $*.cc

.C$(OBJ_EXT) :
	$(CCCMD) $(CCCDLFLAGS) "-I$(PERL_INC)" $(PASTHRU_DEFINE) $(DEFINE) $*.C


# --- MakeMaker xs_c section:

.xs.c:
	$(XSUBPPRUN) $(XSPROTOARG) $(XSUBPPARGS) $(XSUBPP_EXTRA_ARGS) $*.xs > $*.xsc
	$(MV) $*.xsc $*.c


# --- MakeMaker xs_o section:
.xs$(OBJ_EXT) :
	$(XSUBPPRUN) $(XSPROTOARG) $(XSUBPPARGS) $*.xs > $*.xsc
	$(MV) $*.xsc $*.c
	$(CCCMD) $(CCCDLFLAGS) "-I$(PERL_INC)" $(PASTHRU_DEFINE) $(DEFINE) $*.c 


# --- MakeMaker top_targets section:
all :: pure_all manifypods
	$(NOECHO) $(NOOP)

pure_all :: config pm_to_blib subdirs linkext
	$(NOECHO) $(NOOP)

	$(NOECHO) $(NOOP)

subdirs :: $(MYEXTLIB)
	$(NOECHO) $(NOOP)

config :: $(FIRST_MAKEFILE) blibdirs
	$(NOECHO) $(NOOP)

help :
	perldoc ExtUtils::MakeMaker


# --- MakeMaker blibdirs section:
blibdirs : $(INST_LIBDIR)$(DFSEP).exists $(INST_ARCHLIB)$(DFSEP).exists $(INST_AUTODIR)$(DFSEP).exists $(INST_ARCHAUTODIR)$(DFSEP).exists $(INST_BIN)$(DFSEP).exists $(INST_SCRIPT)$(DFSEP).exists $(INST_MAN1DIR)$(DFSEP).exists $(INST_MAN3DIR)$(DFSEP).exists
	$(NOECHO) $(NOOP)

# Backwards compat with 6.18 through 6.25
blibdirs.ts : blibdirs
	$(NOECHO) $(NOOP)

$(INST_LIBDIR)$(DFSEP).exists :: Makefile.PL
	$(NOECHO) $(MKPATH) $(INST_LIBDIR)
	$(NOECHO) $(CHMOD) $(PERM_DIR) $(INST_LIBDIR)
	$(NOECHO) $(TOUCH) $(INST_LIBDIR)$(DFSEP).exists

$(INST_ARCHLIB)$(DFSEP).exists :: Makefile.PL
	$(NOECHO) $(MKPATH) $(INST_ARCHLIB)
	$(NOECHO) $(CHMOD) $(PERM_DIR) $(INST_ARCHLIB)
	$(NOECHO) $(TOUCH) $(INST_ARCHLIB)$(DFSEP).exists

$(INST_AUTODIR)$(DFSEP).exists :: Makefile.PL
	$(NOECHO) $(MKPATH) $(INST_AUTODIR)
	$(NOECHO) $(CHMOD) $(PERM_DIR) $(INST_AUTODIR)
	$(NOECHO) $(TOUCH) $(INST_AUTODIR)$(DFSEP).exists

$(INST_ARCHAUTODIR)$(DFSEP).exists :: Makefile.PL
	$(NOECHO) $(MKPATH) $(INST_ARCHAUTODIR)
	$(NOECHO) $(CHMOD) $(PERM_DIR) $(INST_ARCHAUTODIR)
	$(NOECHO) $(TOUCH) $(INST_ARCHAUTODIR)$(DFSEP).exists

$(INST_BIN)$(DFSEP).exists :: Makefile.PL
	$(NOECHO) $(MKPATH) $(INST_BIN)
	$(NOECHO) $(CHMOD) $(PERM_DIR) $(INST_BIN)
	$(NOECHO) $(TOUCH) $(INST_BIN)$(DFSEP).exists

$(INST_SCRIPT)$(DFSEP).exists :: Makefile.PL
	$(NOECHO) $(MKPATH) $(INST_SCRIPT)
	$(NOECHO) $(CHMOD) $(PERM_DIR) $(INST_SCRIPT)
	$(NOECHO) $(TOUCH) $(INST_SCRIPT)$(DFSEP).exists

$(INST_MAN1DIR)$(DFSEP).exists :: Makefile.PL
	$(NOECHO) $(MKPATH) $(INST_MAN1DIR)
	$(NOECHO) $(CHMOD) $(PERM_DIR) $(INST_MAN1DIR)
	$(NOECHO) $(TOUCH) $(INST_MAN1DIR)$(DFSEP).exists

$(INST_MAN3DIR)$(DFSEP).exists :: Makefile.PL
	$(NOECHO) $(MKPATH) $(INST_MAN3DIR)
	$(NOECHO) $(CHMOD) $(PERM_DIR) $(INST_MAN3DIR)
	$(NOECHO) $(TOUCH) $(INST_MAN3DIR)$(DFSEP).exists



# --- MakeMaker linkext section:

linkext :: dynamic
	$(NOECHO) $(NOOP)


# --- MakeMaker dlsyms section:


# --- MakeMaker dynamic_bs section:
BOOTSTRAP = $(BASEEXT).bs

# As Mkbootstrap might not write a file (if none is required)
# we use touch to prevent make continually trying to remake it.
# The DynaLoader only reads a non-empty file.
$(BASEEXT).bs : $(FIRST_MAKEFILE) $(BOOTDEP)
	$(NOECHO) $(ECHO) "Running Mkbootstrap for $(BASEEXT) ($(BSLOADLIBS))"
	$(NOECHO) $(PERLRUN) \
		"-MExtUtils::Mkbootstrap" \
		-e "Mkbootstrap('$(BASEEXT)','$(BSLOADLIBS)');"
	$(NOECHO) $(TOUCH) "$(BASEEXT).bs"
	$(CHMOD) $(PERM_RW) "$(BASEEXT).bs"

$(INST_ARCHAUTODIR)/$(BASEEXT).bs : $(BASEEXT).bs $(INST_ARCHAUTODIR)$(DFSEP).exists
	$(NOECHO) $(RM_RF) $(INST_ARCHAUTODIR)/$(BASEEXT).bs
	- $(CP_NONEMPTY) $(BASEEXT).bs $(INST_ARCHAUTODIR)/$(BASEEXT).bs $(PERM_RW)


# --- MakeMaker dynamic section:

dynamic :: $(FIRST_MAKEFILE) config $(INST_BOOT) $(INST_DYNAMIC)
	$(NOECHO) $(NOOP)


# --- MakeMaker dynamic_lib section:
# This section creates the dynamically loadable objects from relevant
# objects and possibly $(MYEXTLIB).
ARMAYBE = :
OTHERLDFLAGS = 
INST_DYNAMIC_DEP = 
INST_DYNAMIC_FIX = 

$(INST_DYNAMIC) : $(OBJECT) $(MYEXTLIB) $(INST_ARCHAUTODIR)$(DFSEP).exists $(EXPORT_LIST) $(PERL_ARCHIVEDEP) $(PERL_ARCHIVE_AFTER) $(INST_DYNAMIC_DEP) 
	$(RM_F) $@
	LD_RUN_PATH="$(LD_RUN_PATH)" $(LD)  $(LDDLFLAGS)  $(LDFROM) $(OTHERLDFLAGS) -o $@ $(MYEXTLIB) \
	  $(PERL_ARCHIVE) $(LDLOADLIBS) $(PERL_ARCHIVE_AFTER) $(EXPORT_LIST) \
	  $(INST_DYNAMIC_FIX)
	$(CHMOD) $(PERM_RWX) $@


# --- MakeMaker static section:

## $(INST_PM) has been moved to the all: target.
## It remains here for awhile to allow for old usage: "make static"
static :: $(FIRST_MAKEFILE) $(INST_STATIC)
	$(NOECHO) $(NOOP)


# --- MakeMaker static_lib section:
$(INST_STATIC): $(OBJECT) $(MYEXTLIB) $(INST_ARCHAUTODIR)$(DFSEP).exists
	$(RM_F) "$@"
	$(FULL_AR) $(AR_STATIC_ARGS) "$@" $(OBJECT)
	$(RANLIB) "$@"
	$(CHMOD) $(PERM_RWX) $@
	$(NOECHO) $(ECHO) "$(EXTRALIBS)" > $(INST_ARCHAUTODIR)$(DFSEP)extralibs.ld


# --- MakeMaker manifypods section:

POD2MAN_EXE = $(PERLRUN) "-MExtUtils::Command::MM" -e pod2man "--"
POD2MAN = $(POD2MAN_EXE)


manifypods : pure_all config 
	$(NOECHO) $(NOOP)




# --- MakeMaker processPL section:


# --- MakeMaker installbin section:


# --- MakeMaker subdirs section:

# none

# --- MakeMaker clean_subdirs section:
clean_subdirs :
	$(NOECHO) $(NOOP)


# --- MakeMaker clean section:

# Delete temporary files but do not touch installed files. We don't delete
# the Makefile here so a later make realclean still has a makefile to use.

clean :: clean_subdirs
	- $(RM_F) \
	  $(BASEEXT).bso $(BASEEXT).def \
	  $(BASEEXT).exp $(BASEEXT).x \
	  $(BOOTSTRAP) $(INST_ARCHAUTODIR)/extralibs.all \
	  $(INST_ARCHAUTODIR)/extralibs.ld $(MAKE_APERL_FILE) \
	  *$(LIB_EXT) *$(OBJ_EXT) \
	  *perl.core MYMETA.json \
	  MYMETA.yml blibdirs.ts \
	  core core.*perl.*.? \
	  core.[0-9] core.[0-9][0-9] \
	  core.[0-9][0-9][0-9] core.[0-9][0-9][0-9][0-9] \
	  core.[0-9][0-9][0-9][0-9][0-9] lib$(BASEEXT).def \
	  mon.out perl \
	  perl$(EXE_EXT) perl.exe \
	  perlmain.c pm_to_blib \
	  pm_to_blib.ts so_locations \
	  tmon.out 
	- $(RM_RF) \
	  blib 
	  $(NOECHO) $(RM_F) $(MAKEFILE_OLD)
	- $(MV) $(FIRST_MAKEFILE) $(MAKEFILE_OLD) $(DEV_NULL)


# --- MakeMaker realclean_subdirs section:
# so clean is forced to complete before realclean_subdirs runs
realclean_subdirs : clean
	$(NOECHO) $(NOOP)


# --- MakeMaker realclean section:
# Delete temporary files (via clean) and also delete dist files
realclean purge :: realclean_subdirs
	- $(RM_F) \
	  $(FIRST_MAKEFILE) $(MAKEFILE_OLD) \
	  $(OBJECT) 
	- $(RM_RF) \
	  $(DISTVNAME) 


# --- MakeMaker metafile section:
metafile : create_distdir
	$(NOECHO) $(ECHO) Generating META.yml
	$(NOECHO) $(ECHO) '---' > META_new.yml
	$(NOECHO) $(ECHO) 'abstract: '\''Perl bindings for Subversion'\''' >> META_new.yml
	$(NOECHO) $(ECHO) 'author:' >> META_new.yml
	$(NOECHO) $(ECHO) '  - unknown' >> META_new.yml
	$(NOECHO) $(ECHO) 'build_requires:' >> META_new.yml
	$(NOECHO) $(ECHO) '  ExtUtils::MakeMaker: '\''0'\''' >> META_new.yml
	$(NOECHO) $(ECHO) 'configure_requires:' >> META_new.yml
	$(NOECHO) $(ECHO) '  ExtUtils::MakeMaker: '\''0'\''' >> META_new.yml
	$(NOECHO) $(ECHO) 'dynamic_config: 1' >> META_new.yml
	$(NOECHO) $(ECHO) 'generated_by: '\''ExtUtils::MakeMaker version 7.34, CPAN::Meta::Converter version 2.150010'\''' >> META_new.yml
	$(NOECHO) $(ECHO) 'license: unknown' >> META_new.yml
	$(NOECHO) $(ECHO) 'meta-spec:' >> META_new.yml
	$(NOECHO) $(ECHO) '  url: http://module-build.sourceforge.net/META-spec-v1.4.html' >> META_new.yml
	$(NOECHO) $(ECHO) '  version: '\''1.4'\''' >> META_new.yml
	$(NOECHO) $(ECHO) 'name: SVN-_Fs' >> META_new.yml
	$(NOECHO) $(ECHO) 'no_index:' >> META_new.yml
	$(NOECHO) $(ECHO) '  directory:' >> META_new.yml
	$(NOECHO) $(ECHO) '    - t' >> META_new.yml
	$(NOECHO) $(ECHO) '    - inc' >> META_new.yml
	$(NOECHO) $(ECHO) 'version: '\'''\''' >> META_new.yml
	$(NOECHO) $(ECHO) 'x_serialization_backend: '\''CPAN::Meta::YAML version 0.018'\''' >> META_new.yml
	-$(NOECHO) $(MV) META_new.yml $(DISTVNAME)/META.yml
	$(NOECHO) $(ECHO) Generating META.json
	$(NOECHO) $(ECHO) '{' > META_new.json
	$(NOECHO) $(ECHO) '   "abstract" : "Perl bindings for Subversion",' >> META_new.json
	$(NOECHO) $(ECHO) '   "author" : [' >> META_new.json
	$(NOECHO) $(ECHO) '      "unknown"' >> META_new.json
	$(NOECHO) $(ECHO) '   ],' >> META_new.json
	$(NOECHO) $(ECHO) '   "dynamic_config" : 1,' >> META_new.json
	$(NOECHO) $(ECHO) '   "generated_by" : "ExtUtils::MakeMaker version 7.34, CPAN::Meta::Converter version 2.150010",' >> META_new.json
	$(NOECHO) $(ECHO) '   "license" : [' >> META_new.json
	$(NOECHO) $(ECHO) '      "unknown"' >> META_new.json
	$(NOECHO) $(ECHO) '   ],' >> META_new.json
	$(NOECHO) $(ECHO) '   "meta-spec" : {' >> META_new.json
	$(NOECHO) $(ECHO) '      "url" : "http://search.cpan.org/perldoc?CPAN::Meta::Spec",' >> META_new.json
	$(NOECHO) $(ECHO) '      "version" : 2' >> META_new.json
	$(NOECHO) $(ECHO) '   },' >> META_new.json
	$(NOECHO) $(ECHO) '   "name" : "SVN-_Fs",' >> META_new.json
	$(NOECHO) $(ECHO) '   "no_index" : {' >> META_new.json
	$(NOECHO) $(ECHO) '      "directory" : [' >> META_new.json
	$(NOECHO) $(ECHO) '         "t",' >> META_new.json
	$(NOECHO) $(ECHO) '         "inc"' >> META_new.json
	$(NOECHO) $(ECHO) '      ]' >> META_new.json
	$(NOECHO) $(ECHO) '   },' >> META_new.json
	$(NOECHO) $(ECHO) '   "prereqs" : {' >> META_new.json
	$(NOECHO) $(ECHO) '      "build" : {' >> META_new.json
	$(NOECHO) $(ECHO) '         "requires" : {' >> META_new.json
	$(NOECHO) $(ECHO) '            "ExtUtils::MakeMaker" : "0"' >> META_new.json
	$(NOECHO) $(ECHO) '         }' >> META_new.json
	$(NOECHO) $(ECHO) '      },' >> META_new.json
	$(NOECHO) $(ECHO) '      "configure" : {' >> META_new.json
	$(NOECHO) $(ECHO) '         "requires" : {' >> META_new.json
	$(NOECHO) $(ECHO) '            "ExtUtils::MakeMaker" : "0"' >> META_new.json
	$(NOECHO) $(ECHO) '         }' >> META_new.json
	$(NOECHO) $(ECHO) '      }' >> META_new.json
	$(NOECHO) $(ECHO) '   },' >> META_new.json
	$(NOECHO) $(ECHO) '   "release_status" : "stable",' >> META_new.json
	$(NOECHO) $(ECHO) '   "version" : "",' >> META_new.json
	$(NOECHO) $(ECHO) '   "x_serialization_backend" : "JSON::PP version 2.97001"' >> META_new.json
	$(NOECHO) $(ECHO) '}' >> META_new.json
	-$(NOECHO) $(MV) META_new.json $(DISTVNAME)/META.json


# --- MakeMaker signature section:
signature :
	cpansign -s


# --- MakeMaker dist_basics section:
distclean :: realclean distcheck
	$(NOECHO) $(NOOP)

distcheck :
	$(PERLRUN) "-MExtUtils::Manifest=fullcheck" -e fullcheck

skipcheck :
	$(PERLRUN) "-MExtUtils::Manifest=skipcheck" -e skipcheck

manifest :
	$(PERLRUN) "-MExtUtils::Manifest=mkmanifest" -e mkmanifest

veryclean : realclean
	$(RM_F) *~ */*~ *.orig */*.orig *.bak */*.bak *.old */*.old



# --- MakeMaker dist_core section:

dist : $(DIST_DEFAULT) $(FIRST_MAKEFILE)
	$(NOECHO) $(ABSPERLRUN) -l -e 'print '\''Warning: Makefile possibly out of date with $(VERSION_FROM)'\''' \
	  -e '    if -e '\''$(VERSION_FROM)'\'' and -M '\''$(VERSION_FROM)'\'' < -M '\''$(FIRST_MAKEFILE)'\'';' --

tardist : $(DISTVNAME).tar$(SUFFIX)
	$(NOECHO) $(NOOP)

uutardist : $(DISTVNAME).tar$(SUFFIX)
	uuencode $(DISTVNAME).tar$(SUFFIX) $(DISTVNAME).tar$(SUFFIX) > $(DISTVNAME).tar$(SUFFIX)_uu
	$(NOECHO) $(ECHO) 'Created $(DISTVNAME).tar$(SUFFIX)_uu'

$(DISTVNAME).tar$(SUFFIX) : distdir
	$(PREOP)
	$(TO_UNIX)
	$(TAR) $(TARFLAGS) $(DISTVNAME).tar $(DISTVNAME)
	$(RM_RF) $(DISTVNAME)
	$(COMPRESS) $(DISTVNAME).tar
	$(NOECHO) $(ECHO) 'Created $(DISTVNAME).tar$(SUFFIX)'
	$(POSTOP)

zipdist : $(DISTVNAME).zip
	$(NOECHO) $(NOOP)

$(DISTVNAME).zip : distdir
	$(PREOP)
	$(ZIP) $(ZIPFLAGS) $(DISTVNAME).zip $(DISTVNAME)
	$(RM_RF) $(DISTVNAME)
	$(NOECHO) $(ECHO) 'Created $(DISTVNAME).zip'
	$(POSTOP)

shdist : distdir
	$(PREOP)
	$(SHAR) $(DISTVNAME) > $(DISTVNAME).shar
	$(RM_RF) $(DISTVNAME)
	$(NOECHO) $(ECHO) 'Created $(DISTVNAME).shar'
	$(POSTOP)


# --- MakeMaker distdir section:
create_distdir :
	$(RM_RF) $(DISTVNAME)
	$(PERLRUN) "-MExtUtils::Manifest=manicopy,maniread" \
		-e "manicopy(maniread(),'$(DISTVNAME)', '$(DIST_CP)');"

distdir : create_distdir distmeta 
	$(NOECHO) $(NOOP)



# --- MakeMaker dist_test section:
disttest : distdir
	cd $(DISTVNAME) && $(ABSPERLRUN) Makefile.PL "PREFIX=/usr"
	cd $(DISTVNAME) && $(MAKE) $(PASTHRU)
	cd $(DISTVNAME) && $(MAKE) test $(PASTHRU)



# --- MakeMaker dist_ci section:
ci :
	$(ABSPERLRUN) -MExtUtils::Manifest=maniread -e '@all = sort keys %{ maniread() };' \
	  -e 'print(qq{Executing $(CI) @all\n});' \
	  -e 'system(qq{$(CI) @all}) == 0 or die $$!;' \
	  -e 'print(qq{Executing $(RCS_LABEL) ...\n});' \
	  -e 'system(qq{$(RCS_LABEL) @all}) == 0 or die $$!;' --


# --- MakeMaker distmeta section:
distmeta : create_distdir metafile
	$(NOECHO) cd $(DISTVNAME) && $(ABSPERLRUN) -MExtUtils::Manifest=maniadd -e 'exit unless -e q{META.yml};' \
	  -e 'eval { maniadd({q{META.yml} => q{Module YAML meta-data (added by MakeMaker)}}) }' \
	  -e '    or die "Could not add META.yml to MANIFEST: $${'\''@'\''}"' --
	$(NOECHO) cd $(DISTVNAME) && $(ABSPERLRUN) -MExtUtils::Manifest=maniadd -e 'exit unless -f q{META.json};' \
	  -e 'eval { maniadd({q{META.json} => q{Module JSON meta-data (added by MakeMaker)}}) }' \
	  -e '    or die "Could not add META.json to MANIFEST: $${'\''@'\''}"' --



# --- MakeMaker distsignature section:
distsignature : distmeta
	$(NOECHO) cd $(DISTVNAME) && $(ABSPERLRUN) -MExtUtils::Manifest=maniadd -e 'eval { maniadd({q{SIGNATURE} => q{Public-key signature (added by MakeMaker)}}) }' \
	  -e '    or die "Could not add SIGNATURE to MANIFEST: $${'\''@'\''}"' --
	$(NOECHO) cd $(DISTVNAME) && $(TOUCH) SIGNATURE
	cd $(DISTVNAME) && cpansign -s



# --- MakeMaker install section:

install :: pure_install doc_install
	$(NOECHO) $(NOOP)

install_perl :: pure_perl_install doc_perl_install
	$(NOECHO) $(NOOP)

install_site :: pure_site_install doc_site_install
	$(NOECHO) $(NOOP)

install_vendor :: pure_vendor_install doc_vendor_install
	$(NOECHO) $(NOOP)

pure_install :: pure_$(INSTALLDIRS)_install
	$(NOECHO) $(NOOP)

doc_install :: doc_$(INSTALLDIRS)_install
	$(NOECHO) $(NOOP)

pure__install : pure_site_install
	$(NOECHO) $(ECHO) INSTALLDIRS not defined, defaulting to INSTALLDIRS=site

doc__install : doc_site_install
	$(NOECHO) $(ECHO) INSTALLDIRS not defined, defaulting to INSTALLDIRS=site

pure_perl_install :: all
	$(NOECHO) umask 022; $(MOD_INSTALL) \
		"$(INST_LIB)" "$(DESTINSTALLPRIVLIB)" \
		"$(INST_ARCHLIB)" "$(DESTINSTALLARCHLIB)" \
		"$(INST_BIN)" "$(DESTINSTALLBIN)" \
		"$(INST_SCRIPT)" "$(DESTINSTALLSCRIPT)" \
		"$(INST_MAN1DIR)" "$(DESTINSTALLMAN1DIR)" \
		"$(INST_MAN3DIR)" "$(DESTINSTALLMAN3DIR)"
	$(NOECHO) $(WARN_IF_OLD_PACKLIST) \
		"$(SITEARCHEXP)/auto/$(FULLEXT)"


pure_site_install :: all
	$(NOECHO) umask 02; $(MOD_INSTALL) \
		read "$(SITEARCHEXP)/auto/$(FULLEXT)/.packlist" \
		write "$(DESTINSTALLSITEARCH)/auto/$(FULLEXT)/.packlist" \
		"$(INST_LIB)" "$(DESTINSTALLSITELIB)" \
		"$(INST_ARCHLIB)" "$(DESTINSTALLSITEARCH)" \
		"$(INST_BIN)" "$(DESTINSTALLSITEBIN)" \
		"$(INST_SCRIPT)" "$(DESTINSTALLSITESCRIPT)" \
		"$(INST_MAN1DIR)" "$(DESTINSTALLSITEMAN1DIR)" \
		"$(INST_MAN3DIR)" "$(DESTINSTALLSITEMAN3DIR)"
	$(NOECHO) $(WARN_IF_OLD_PACKLIST) \
		"$(PERL_ARCHLIB)/auto/$(FULLEXT)"

pure_vendor_install :: all
	$(NOECHO) umask 022; $(MOD_INSTALL) \
		"$(INST_LIB)" "$(DESTINSTALLVENDORLIB)" \
		"$(INST_ARCHLIB)" "$(DESTINSTALLVENDORARCH)" \
		"$(INST_BIN)" "$(DESTINSTALLVENDORBIN)" \
		"$(INST_SCRIPT)" "$(DESTINSTALLVENDORSCRIPT)" \
		"$(INST_MAN1DIR)" "$(DESTINSTALLVENDORMAN1DIR)" \
		"$(INST_MAN3DIR)" "$(DESTINSTALLVENDORMAN3DIR)"


doc_perl_install :: all

doc_site_install :: all
	$(NOECHO) $(ECHO) Appending installation info to "$(DESTINSTALLSITEARCH)/perllocal.pod"
	-$(NOECHO) umask 02; $(MKPATH) "$(DESTINSTALLSITEARCH)"
	-$(NOECHO) umask 02; $(DOC_INSTALL) \
		"Module" "$(NAME)" \
		"installed into" "$(INSTALLSITELIB)" \
		LINKTYPE "$(LINKTYPE)" \
		VERSION "$(VERSION)" \
		EXE_FILES "$(EXE_FILES)" \
		>> "$(DESTINSTALLSITEARCH)/perllocal.pod"

doc_vendor_install :: all


uninstall :: uninstall_from_$(INSTALLDIRS)dirs
	$(NOECHO) $(NOOP)

uninstall_from_perldirs ::

uninstall_from_sitedirs ::
	$(NOECHO) $(UNINSTALL) "$(SITEARCHEXP)/auto/$(FULLEXT)/.packlist"

uninstall_from_vendordirs ::


# --- MakeMaker force section:
# Phony target to force checking subdirectories.
FORCE :
	$(NOECHO) $(NOOP)


# --- MakeMaker perldepend section:
PERL_HDRS = \
        $(PERL_INCDEP)/EXTERN.h            \
        $(PERL_INCDEP)/INTERN.h            \
        $(PERL_INCDEP)/XSUB.h            \
        $(PERL_INCDEP)/av.h            \
        $(PERL_INCDEP)/bitcount.h            \
        $(PERL_INCDEP)/charclass_invlists.h            \
        $(PERL_INCDEP)/config.h            \
        $(PERL_INCDEP)/cop.h            \
        $(PERL_INCDEP)/cv.h            \
        $(PERL_INCDEP)/dosish.h            \
        $(PERL_INCDEP)/dquote_inline.h            \
        $(PERL_INCDEP)/ebcdic_tables.h            \
        $(PERL_INCDEP)/embed.h            \
        $(PERL_INCDEP)/embedvar.h            \
        $(PERL_INCDEP)/fakesdio.h            \
        $(PERL_INCDEP)/feature.h            \
        $(PERL_INCDEP)/form.h            \
        $(PERL_INCDEP)/git_version.h            \
        $(PERL_INCDEP)/gv.h            \
        $(PERL_INCDEP)/handy.h            \
        $(PERL_INCDEP)/hv.h            \
        $(PERL_INCDEP)/hv_func.h            \
        $(PERL_INCDEP)/hv_macro.h            \
        $(PERL_INCDEP)/inline.h            \
        $(PERL_INCDEP)/intrpvar.h            \
        $(PERL_INCDEP)/invlist_inline.h            \
        $(PERL_INCDEP)/iperlsys.h            \
        $(PERL_INCDEP)/keywords.h            \
        $(PERL_INCDEP)/l1_char_class_tab.h            \
        $(PERL_INCDEP)/malloc_ctl.h            \
        $(PERL_INCDEP)/metaconfig.h            \
        $(PERL_INCDEP)/mg.h            \
        $(PERL_INCDEP)/mg_data.h            \
        $(PERL_INCDEP)/mg_raw.h            \
        $(PERL_INCDEP)/mg_vtable.h            \
        $(PERL_INCDEP)/mydtrace.h            \
        $(PERL_INCDEP)/nostdio.h            \
        $(PERL_INCDEP)/op.h            \
        $(PERL_INCDEP)/op_reg_common.h            \
        $(PERL_INCDEP)/opcode.h            \
        $(PERL_INCDEP)/opnames.h            \
        $(PERL_INCDEP)/overload.h            \
        $(PERL_INCDEP)/pad.h            \
        $(PERL_INCDEP)/parser.h            \
        $(PERL_INCDEP)/patchlevel-debian.h            \
        $(PERL_INCDEP)/patchlevel.h            \
        $(PERL_INCDEP)/perl.h            \
        $(PERL_INCDEP)/perl_inc_macro.h            \
        $(PERL_INCDEP)/perl_langinfo.h            \
        $(PERL_INCDEP)/perlapi.h            \
        $(PERL_INCDEP)/perlio.h            \
        $(PERL_INCDEP)/perliol.h            \
        $(PERL_INCDEP)/perlsdio.h            \
        $(PERL_INCDEP)/perlvars.h            \
        $(PERL_INCDEP)/perly.h            \
        $(PERL_INCDEP)/pp.h            \
        $(PERL_INCDEP)/pp_proto.h            \
        $(PERL_INCDEP)/proto.h            \
        $(PERL_INCDEP)/reentr.h            \
        $(PERL_INCDEP)/regcharclass.h            \
        $(PERL_INCDEP)/regcomp.h            \
        $(PERL_INCDEP)/regexp.h            \
        $(PERL_INCDEP)/regnodes.h            \
        $(PERL_INCDEP)/sbox32_hash.h            \
        $(PERL_INCDEP)/scope.h            \
        $(PERL_INCDEP)/stadtx_hash.h            \
        $(PERL_INCDEP)/sv.h            \
        $(PERL_INCDEP)/thread.h            \
        $(PERL_INCDEP)/time64.h            \
        $(PERL_INCDEP)/time64_config.h            \
        $(PERL_INCDEP)/uconfig.h            \
        $(PERL_INCDEP)/uni_keywords.h            \
        $(PERL_INCDEP)/unicode_constants.h            \
        $(PERL_INCDEP)/unixish.h            \
        $(PERL_INCDEP)/utf8.h            \
        $(PERL_INCDEP)/utfebcdic.h            \
        $(PERL_INCDEP)/util.h            \
        $(PERL_INCDEP)/uudmap.h            \
        $(PERL_INCDEP)/vutil.h            \
        $(PERL_INCDEP)/warnings.h            \
        $(PERL_INCDEP)/zaphod32_hash.h            

$(OBJECT) : $(PERL_HDRS)


# --- MakeMaker makefile section:

$(OBJECT) : $(FIRST_MAKEFILE)

# We take a very conservative approach here, but it's worth it.
# We move Makefile to Makefile.old here to avoid gnu make looping.
$(FIRST_MAKEFILE) : Makefile.PL $(CONFIGDEP)
	$(NOECHO) $(ECHO) "Makefile out-of-date with respect to $?"
	$(NOECHO) $(ECHO) "Cleaning current config before rebuilding Makefile..."
	-$(NOECHO) $(RM_F) $(MAKEFILE_OLD)
	-$(NOECHO) $(MV)   $(FIRST_MAKEFILE) $(MAKEFILE_OLD)
	- $(MAKE) $(USEMAKEFILE) $(MAKEFILE_OLD) clean $(DEV_NULL)
	$(PERLRUN) Makefile.PL "PREFIX=/usr"
	$(NOECHO) $(ECHO) "==> Your Makefile has been rebuilt. <=="
	$(NOECHO) $(ECHO) "==> Please rerun the $(MAKE) command.  <=="
	$(FALSE)



# --- MakeMaker staticmake section:

# --- MakeMaker makeaperl section ---
MAP_TARGET    = perl
FULLPERL      = "/usr/bin/perl"
MAP_PERLINC   = "-Iblib/arch" "-Iblib/lib" "-I/usr/lib/x86_64-linux-gnu/perl/5.28" "-I/usr/share/perl/5.28"

$(MAP_TARGET) :: $(MAKE_APERL_FILE)
	$(MAKE) $(USEMAKEFILE) $(MAKE_APERL_FILE) $@

$(MAKE_APERL_FILE) : static $(FIRST_MAKEFILE) pm_to_blib
	$(NOECHO) $(ECHO) Writing \"$(MAKE_APERL_FILE)\" for this $(MAP_TARGET)
	$(NOECHO) $(PERLRUNINST) \
		Makefile.PL DIR="" \
		MAKEFILE=$(MAKE_APERL_FILE) LINKTYPE=static \
		MAKEAPERL=1 NORECURS=1 CCCDLFLAGS= \
		PREFIX=/usr


# --- MakeMaker test section:
TEST_VERBOSE=0
TEST_TYPE=test_$(LINKTYPE)
TEST_FILE = test.pl
TEST_FILES = /home/richard/debs/svn/subversion-1.11.0/subversion/bindings/swig/perl/native/t/*.t
TESTDB_SW = -d

testdb :: testdb_$(LINKTYPE)
	$(NOECHO) $(NOOP)

test :: $(TEST_TYPE)
	$(NOECHO) $(NOOP)

# Occasionally we may face this degenerate target:
test_ : test_dynamic
	$(NOECHO) $(NOOP)

subdirs-test_dynamic :: dynamic pure_all

test_dynamic :: subdirs-test_dynamic
	PERL_DL_NONLAZY=1 $(FULLPERLRUN) "-MExtUtils::Command::MM" "-MTest::Harness" "-e" "undef *Test::Harness::Switches; test_harness($(TEST_VERBOSE), '$(INST_LIB)', '$(INST_ARCHLIB)')" $(TEST_FILES)

testdb_dynamic :: dynamic pure_all
	PERL_DL_NONLAZY=1 $(FULLPERLRUN) $(TESTDB_SW) "-I$(INST_LIB)" "-I$(INST_ARCHLIB)" $(TEST_FILE)

subdirs-test_static :: static pure_all

test_static :: subdirs-test_static $(MAP_TARGET)
	PERL_DL_NONLAZY=1 "/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/bindings/swig/perl/native/$(MAP_TARGET)" $(MAP_PERLINC) "-MExtUtils::Command::MM" "-MTest::Harness" "-e" "undef *Test::Harness::Switches; test_harness($(TEST_VERBOSE), '$(INST_LIB)', '$(INST_ARCHLIB)')" $(TEST_FILES)

testdb_static :: static pure_all $(MAP_TARGET)
	PERL_DL_NONLAZY=1 "/home/richard/debs/svn/subversion-1.11.0/BUILD/subversion/bindings/swig/perl/native/$(MAP_TARGET)" $(MAP_PERLINC) "-I$(INST_LIB)" "-I$(INST_ARCHLIB)" $(TEST_FILE)



# --- MakeMaker ppd section:
# Creates a PPD (Perl Package Description) for a binary distribution.
ppd :
	$(NOECHO) $(ECHO) '<SOFTPKG NAME="SVN-_Fs" VERSION="">' > SVN-_Fs.ppd
	$(NOECHO) $(ECHO) '    <ABSTRACT>Perl bindings for Subversion</ABSTRACT>' >> SVN-_Fs.ppd
	$(NOECHO) $(ECHO) '    <AUTHOR></AUTHOR>' >> SVN-_Fs.ppd
	$(NOECHO) $(ECHO) '    <IMPLEMENTATION>' >> SVN-_Fs.ppd
	$(NOECHO) $(ECHO) '        <ARCHITECTURE NAME="x86_64-linux-gnu-thread-multi-5.28" />' >> SVN-_Fs.ppd
	$(NOECHO) $(ECHO) '        <CODEBASE HREF="" />' >> SVN-_Fs.ppd
	$(NOECHO) $(ECHO) '    </IMPLEMENTATION>' >> SVN-_Fs.ppd
	$(NOECHO) $(ECHO) '</SOFTPKG>' >> SVN-_Fs.ppd


# --- MakeMaker pm_to_blib section:

pm_to_blib : $(FIRST_MAKEFILE) $(TO_INST_PM)
	$(NOECHO) $(TOUCH) pm_to_blib


# --- MakeMaker selfdocument section:

# here so even if top_targets is overridden, these will still be defined
# gmake will silently still work if any are .PHONY-ed but nmake won't

static ::
	$(NOECHO) $(NOOP)

dynamic ::
	$(NOECHO) $(NOOP)

config ::
	$(NOECHO) $(NOOP)


# --- MakeMaker postamble section:


# End.
