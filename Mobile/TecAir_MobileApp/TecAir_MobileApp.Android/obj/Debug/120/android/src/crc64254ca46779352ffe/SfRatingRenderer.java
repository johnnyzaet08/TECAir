package crc64254ca46779352ffe;


public class SfRatingRenderer
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
		mono.android.Runtime.register ("Syncfusion.SfRating.XForms.Droid.SfRatingRenderer, Syncfusion.SfRating.XForms.Android", SfRatingRenderer.class, __md_methods);
	}


	public SfRatingRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SfRatingRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfRating.XForms.Droid.SfRatingRenderer, Syncfusion.SfRating.XForms.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public SfRatingRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SfRatingRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfRating.XForms.Droid.SfRatingRenderer, Syncfusion.SfRating.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public SfRatingRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SfRatingRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfRating.XForms.Droid.SfRatingRenderer, Syncfusion.SfRating.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
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
