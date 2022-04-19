package crc64c9e0fc3fe4585769;


public class SfButtonRenderer
	extends crc643ddf594df781e5ec.SfBorderRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Syncfusion.Buttons.XForms.SfButtonRenderer, Syncfusion.Buttons.XForms.Android", SfButtonRenderer.class, __md_methods);
	}


	public SfButtonRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SfButtonRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.Buttons.XForms.SfButtonRenderer, Syncfusion.Buttons.XForms.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public SfButtonRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SfButtonRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.Buttons.XForms.SfButtonRenderer, Syncfusion.Buttons.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public SfButtonRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SfButtonRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.Buttons.XForms.SfButtonRenderer, Syncfusion.Buttons.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}

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
