/* DO NOT EDIT THIS FILE - it is machine generated */
#include <jni.h>
/* Header for class org_apache_subversion_javahl_util_ConfigImpl_Category */

#ifndef _Included_org_apache_subversion_javahl_util_ConfigImpl_Category
#define _Included_org_apache_subversion_javahl_util_ConfigImpl_Category
#ifdef __cplusplus
extern "C" {
#endif
/*
 * Class:     org_apache_subversion_javahl_util_ConfigImpl_Category
 * Method:    get_str
 * Signature: (Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
 */
JNIEXPORT jstring JNICALL Java_org_apache_subversion_javahl_util_ConfigImpl_00024Category_get_1str
  (JNIEnv *, jobject, jstring, jlong, jstring, jstring, jstring);

/*
 * Class:     org_apache_subversion_javahl_util_ConfigImpl_Category
 * Method:    get_bool
 * Signature: (Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Z)Z
 */
JNIEXPORT jboolean JNICALL Java_org_apache_subversion_javahl_util_ConfigImpl_00024Category_get_1bool
  (JNIEnv *, jobject, jstring, jlong, jstring, jstring, jboolean);

/*
 * Class:     org_apache_subversion_javahl_util_ConfigImpl_Category
 * Method:    get_long
 * Signature: (Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;J)J
 */
JNIEXPORT jlong JNICALL Java_org_apache_subversion_javahl_util_ConfigImpl_00024Category_get_1long
  (JNIEnv *, jobject, jstring, jlong, jstring, jstring, jlong);

/*
 * Class:     org_apache_subversion_javahl_util_ConfigImpl_Category
 * Method:    get_tri
 * Signature: (Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/apache/subversion/javahl/types/Tristate;)Lorg/apache/subversion/javahl/types/Tristate;
 */
JNIEXPORT jobject JNICALL Java_org_apache_subversion_javahl_util_ConfigImpl_00024Category_get_1tri
  (JNIEnv *, jobject, jstring, jlong, jstring, jstring, jstring, jobject);

/*
 * Class:     org_apache_subversion_javahl_util_ConfigImpl_Category
 * Method:    get_yna
 * Signature: (Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;
 */
JNIEXPORT jstring JNICALL Java_org_apache_subversion_javahl_util_ConfigImpl_00024Category_get_1yna
  (JNIEnv *, jobject, jstring, jlong, jstring, jstring, jstring);

/*
 * Class:     org_apache_subversion_javahl_util_ConfigImpl_Category
 * Method:    set_str
 * Signature: (Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_util_ConfigImpl_00024Category_set_1str
  (JNIEnv *, jobject, jstring, jlong, jstring, jstring, jstring);

/*
 * Class:     org_apache_subversion_javahl_util_ConfigImpl_Category
 * Method:    set_bool
 * Signature: (Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Z)V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_util_ConfigImpl_00024Category_set_1bool
  (JNIEnv *, jobject, jstring, jlong, jstring, jstring, jboolean);

/*
 * Class:     org_apache_subversion_javahl_util_ConfigImpl_Category
 * Method:    set_long
 * Signature: (Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;J)V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_util_ConfigImpl_00024Category_set_1long
  (JNIEnv *, jobject, jstring, jlong, jstring, jstring, jlong);

/*
 * Class:     org_apache_subversion_javahl_util_ConfigImpl_Category
 * Method:    sections
 * Signature: (Ljava/lang/String;J)Ljava/lang/Iterable;
 */
JNIEXPORT jobject JNICALL Java_org_apache_subversion_javahl_util_ConfigImpl_00024Category_sections
  (JNIEnv *, jobject, jstring, jlong);

/*
 * Class:     org_apache_subversion_javahl_util_ConfigImpl_Category
 * Method:    enumerate
 * Signature: (Ljava/lang/String;JLjava/lang/String;Lorg/apache/subversion/javahl/ISVNConfig/Enumerator;)V
 */
JNIEXPORT void JNICALL Java_org_apache_subversion_javahl_util_ConfigImpl_00024Category_enumerate
  (JNIEnv *, jobject, jstring, jlong, jstring, jobject);

#ifdef __cplusplus
}
#endif
#endif