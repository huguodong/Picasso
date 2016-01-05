using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Picasso {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']"
	[global::Android.Runtime.Register ("com/squareup/picasso/LruCache", DoNotGenerateAcw=true)]
	public partial class LruCache : global::Java.Lang.Object, global::Com.Squareup.Picasso.ICache {


		public static class InterfaceConsts {

			// The following are fields from: com.squareup.picasso.Cache

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Cache']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Squareup.Picasso.ICache None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/squareup/picasso/Cache;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ICache> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/squareup/picasso/Cache;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NONE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/squareup/picasso/LruCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LruCache); }
		}

		protected LruCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/constructor[@name='LruCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public LruCache (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LruCache)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", new JValue (p0));
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, new JValue (p0));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/constructor[@name='LruCache' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public LruCache (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LruCache)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_clear);
		}

		static IntPtr id_clearKeyUri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='clearKeyUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clearKeyUri", "(Ljava/lang/String;)V", "")]
		public void ClearKeyUri (string p0)
		{
			if (id_clearKeyUri_Ljava_lang_String_ == IntPtr.Zero)
				id_clearKeyUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clearKeyUri", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_clearKeyUri_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_evictAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='evictAll' and count(parameter)=0]"
		[Register ("evictAll", "()V", "")]
		public void EvictAll ()
		{
			if (id_evictAll == IntPtr.Zero)
				id_evictAll = JNIEnv.GetMethodID (class_ref, "evictAll", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_evictAll);
		}

		static IntPtr id_evictionCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='evictionCount' and count(parameter)=0]"
		[Register ("evictionCount", "()I", "")]
		public int EvictionCount ()
		{
			if (id_evictionCount == IntPtr.Zero)
				id_evictionCount = JNIEnv.GetMethodID (class_ref, "evictionCount", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_evictionCount);
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Picasso.LruCache __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.LruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetGet_Ljava_lang_String_Handler")]
		public virtual global::Android.Graphics.Bitmap Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Graphics.Bitmap __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)Landroid/graphics/Bitmap;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_hitCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='hitCount' and count(parameter)=0]"
		[Register ("hitCount", "()I", "")]
		public int HitCount ()
		{
			if (id_hitCount == IntPtr.Zero)
				id_hitCount = JNIEnv.GetMethodID (class_ref, "hitCount", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_hitCount);
		}

		static IntPtr id_maxSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='maxSize' and count(parameter)=0]"
		[Register ("maxSize", "()I", "")]
		public int MaxSize ()
		{
			if (id_maxSize == IntPtr.Zero)
				id_maxSize = JNIEnv.GetMethodID (class_ref, "maxSize", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_maxSize);
		}

		static IntPtr id_missCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='missCount' and count(parameter)=0]"
		[Register ("missCount", "()I", "")]
		public int MissCount ()
		{
			if (id_missCount == IntPtr.Zero)
				id_missCount = JNIEnv.GetMethodID (class_ref, "missCount", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_missCount);
		}

		static IntPtr id_putCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='putCount' and count(parameter)=0]"
		[Register ("putCount", "()I", "")]
		public int PutCount ()
		{
			if (id_putCount == IntPtr.Zero)
				id_putCount = JNIEnv.GetMethodID (class_ref, "putCount", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_putCount);
		}

		static Delegate cb_set_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_set_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_set_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_set_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static void n_Set_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Squareup.Picasso.LruCache __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.LruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_lang_String_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("set", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "GetSet_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
		public virtual void Set (string p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_set_Ljava_lang_String_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_set_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_set_Ljava_lang_String_Landroid_graphics_Bitmap_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='LruCache']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_size);
		}

	}
}
