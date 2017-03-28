//using System;
//using Android.Runtime;
//using Square.OkHttp3;
//namespace Com.Bumptech.Glide.Integration.Okhttp3
//{
//	public partial class OkHttpStreamFetcher
//	{
//		static IntPtr id_loadData_Lcom_bumptech_glide_Priority_;
//		// Metadata.xml XPath method reference: path="/api/package[@name='com.bumptech.glide.integration.okhttp3']/class[@name='OkHttpStreamFetcher']/method[@name='loadData' and count(parameter)=1 and parameter[1][@type='com.bumptech.glide.Priority']]"
//		[Register("loadData", "(Lcom/bumptech/glide/Priority;)Ljava/io/InputStream;", "GetLoadData_Lcom_bumptech_glide_Priority_Handler")]
//		public virtual unsafe global::Java.IO.InputStream LoadData(global::Com.Bumptech.Glide.Priority p0)
//		{
//			if (id_loadData_Lcom_bumptech_glide_Priority_ == IntPtr.Zero)
//				id_loadData_Lcom_bumptech_glide_Priority_ = JNIEnv.GetMethodID(class_ref, "loadData", "(Lcom/bumptech/glide/Priority;)Ljava/io/InputStream;");
//			try
//			{
//				JValue* __args = stackalloc JValue[1];
//				__args[0] = new JValue(p0);

//				global::Java.IO.InputStream __ret;
//				if (((object)this).GetType() == ThresholdType)
//					__ret = JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_loadData_Lcom_bumptech_glide_Priority_, __args);
//				else
//					__ret = JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "loadData", "(Lcom/bumptech/glide/Priority;)Ljava/io/InputStream;"), __args);
//				return __ret;
//			}
//			finally
//			{
//			}
//		}
//	}
//}
