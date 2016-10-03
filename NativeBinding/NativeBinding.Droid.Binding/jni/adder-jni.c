#include "adder-jni.h"
#include "adder.h"

JNIEXPORT jint JNICALL Java_com_subakstudio_nativebinding_add(JNIEnv * env, jobject thiz, jint a, jint b) {
	return (jint)add((int)a, (int)b);
}
