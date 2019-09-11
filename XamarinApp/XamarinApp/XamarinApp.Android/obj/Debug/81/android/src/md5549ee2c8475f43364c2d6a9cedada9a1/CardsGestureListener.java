package md5549ee2c8475f43364c2d6a9cedada9a1;


public class CardsGestureListener
	extends android.view.GestureDetector.SimpleOnGestureListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFling:(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z:GetOnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler\n" +
			"";
		mono.android.Runtime.register ("Apathys.CalouselViewLib.Droid.CardsGestureListener, Apathys.CalouselViewLib.Droid", CardsGestureListener.class, __md_methods);
	}


	public CardsGestureListener ()
	{
		super ();
		if (getClass () == CardsGestureListener.class)
			mono.android.TypeManager.Activate ("Apathys.CalouselViewLib.Droid.CardsGestureListener, Apathys.CalouselViewLib.Droid", "", this, new java.lang.Object[] {  });
	}


	public boolean onFling (android.view.MotionEvent p0, android.view.MotionEvent p1, float p2, float p3)
	{
		return n_onFling (p0, p1, p2, p3);
	}

	private native boolean n_onFling (android.view.MotionEvent p0, android.view.MotionEvent p1, float p2, float p3);

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
