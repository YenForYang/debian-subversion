/* DO NOT EDIT THIS FILE - it is machine generated */
#include <jni.h>
/* Header for class org_apache_subversion_javahl_remote_CommitEditor */

#ifndef _Included_org_apache_subversion_javahl_remote_CommitEditor
#define _Included_org_apache_subversion_javahl_remote_CommitEditor
#ifdef __cplusplus
extern "C" {
#endif
/*
 * Class:     org_apache_subversion_javahl_remote_CommitEditor
 * Method:    addDirectory
 * Signature: (Ljava/lang/String;Ljava/lang/Iterable;Ljava/util/Map;J)V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_remote_CommitEditor_addDirectory
  (JNIEnv *, jobject, jstring, jobject, jobject, jlong);

/*
 * Class:     org_apache_subversion_javahl_remote_CommitEditor
 * Method:    addFile
 * Signature: (Ljava/lang/String;Lorg/apache/subversion/javahl/types/Checksum;Ljava/io/InputStream;Ljava/util/Map;J)V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_remote_CommitEditor_addFile
  (JNIEnv *, jobject, jstring, jobject, jobject, jobject, jlong);

/*
 * Class:     org_apache_subversion_javahl_remote_CommitEditor
 * Method:    addSymlink
 * Signature: (Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;J)V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_remote_CommitEditor_addSymlink
  (JNIEnv *, jobject, jstring, jstring, jobject, jlong);

/*
 * Class:     org_apache_subversion_javahl_remote_CommitEditor
 * Method:    addAbsent
 * Signature: (Ljava/lang/String;Lorg/apache/subversion/javahl/types/NodeKind;J)V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_remote_CommitEditor_addAbsent
  (JNIEnv *, jobject, jstring, jobject, jlong);

/*
 * Class:     org_apache_subversion_javahl_remote_CommitEditor
 * Method:    alterDirectory
 * Signature: (Ljava/lang/String;JLjava/lang/Iterable;Ljava/util/Map;)V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_remote_CommitEditor_alterDirectory
  (JNIEnv *, jobject, jstring, jlong, jobject, jobject);

/*
 * Class:     org_apache_subversion_javahl_remote_CommitEditor
 * Method:    alterFile
 * Signature: (Ljava/lang/String;JLorg/apache/subversion/javahl/types/Checksum;Ljava/io/InputStream;Ljava/util/Map;)V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_remote_CommitEditor_alterFile
  (JNIEnv *, jobject, jstring, jlong, jobject, jobject, jobject);

/*
 * Class:     org_apache_subversion_javahl_remote_CommitEditor
 * Method:    alterSymlink
 * Signature: (Ljava/lang/String;JLjava/lang/String;Ljava/util/Map;)V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_remote_CommitEditor_alterSymlink
  (JNIEnv *, jobject, jstring, jlong, jstring, jobject);

/*
 * Class:     org_apache_subversion_javahl_remote_CommitEditor
 * Method:    delete
 * Signature: (Ljava/lang/String;J)V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_remote_CommitEditor_delete
  (JNIEnv *, jobject, jstring, jlong);

/*
 * Class:     org_apache_subversion_javahl_remote_CommitEditor
 * Method:    copy
 * Signature: (Ljava/lang/String;JLjava/lang/String;J)V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_remote_CommitEditor_copy
  (JNIEnv *, jobject, jstring, jlong, jstring, jlong);

/*
 * Class:     org_apache_subversion_javahl_remote_CommitEditor
 * Method:    move
 * Signature: (Ljava/lang/String;JLjava/lang/String;J)V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_remote_CommitEditor_move
  (JNIEnv *, jobject, jstring, jlong, jstring, jlong);

/*
 * Class:     org_apache_subversion_javahl_remote_CommitEditor
 * Method:    complete
 * Signature: ()V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_remote_CommitEditor_complete
  (JNIEnv *, jobject);

/*
 * Class:     org_apache_subversion_javahl_remote_CommitEditor
 * Method:    abort
 * Signature: ()V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_remote_CommitEditor_abort
  (JNIEnv *, jobject);

/*
 * Class:     org_apache_subversion_javahl_remote_CommitEditor
 * Method:    finalize
 * Signature: ()V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_remote_CommitEditor_finalize
  (JNIEnv *, jobject);

/*
 * Class:     org_apache_subversion_javahl_remote_CommitEditor
 * Method:    nativeDispose
 * Signature: ()V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_remote_CommitEditor_nativeDispose
  (JNIEnv *, jobject);

/*
 * Class:     org_apache_subversion_javahl_remote_CommitEditor
 * Method:    nativeCreateInstance
 * Signature: (Lorg/apache/subversion/javahl/remote/RemoteSession;Ljava/util/Map;Lorg/apache/subversion/javahl/callback/CommitCallback;Ljava/util/Set;ZLorg/apache/subversion/javahl/ISVNEditor/ProvideBaseCallback;Lorg/apache/subversion/javahl/ISVNEditor/ProvidePropsCallback;Lorg/apache/subversion/javahl/ISVNEditor/GetNodeKindCallback;)J
 */
JNIEXPORT jlong JNICALL Java_org_apache_subversion_javahl_remote_CommitEditor_nativeCreateInstance
  (JNIEnv *, jclass, jobject, jobject, jobject, jobject, jboolean, jobject, jobject, jobject);

#ifdef __cplusplus
}
#endif
#endif
