LOCAL_PATH  :=  $(call my-dir)

include $(CLEAR_VARS) 
LOCAL_MODULE := adder
LOCAL_SRC_FILES := adder.c adder-jni.c

include $(BUILD_SHARED_LIBRARY)
