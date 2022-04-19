package crc64cad742debd39f951;


public class SfPickerRenderer
	extends crc643f46942d9dd1fff9.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSizeChanged:(IIII)V:GetOnSizeChanged_IIIIHandler\n" +
			"";
		mono.android.Runtime.register ("Syncfusion.SfPicker.XForms.Droid.SfPickerRenderer, Syncfusion.SfPicker.XForms.Android", SfPickerRenderer.class, __md_methods);
	}


	public SfPickerRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SfPickerRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfPicker.XForms.Droid.SfPickerRenderer, Syncfusion.SfPicker.XForms.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public SfPickerRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SfPickerRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfPicker.XForms.Droid.SfPickerRenderer, Syncfusion.SfPicker.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public SfPickerRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SfPickerRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfPicker.XForms.Droid.SfPickerRenderer, Syncfusion.SfPicker.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void onSizeChanged (int p0, int p1, int p2, int p3)
	{
		n_onSizeChanged (p0, p1, p2, p3);
	}

	private native void n_onSizeChanged (int p0, int p1, int p2, int p3);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
