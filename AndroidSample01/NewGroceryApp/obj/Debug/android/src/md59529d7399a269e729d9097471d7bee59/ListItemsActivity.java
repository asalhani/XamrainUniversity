package md59529d7399a269e729d9097471d7bee59;


public class ListItemsActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("NewGroceryApp.ListItemsActivity, NewGroceryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ListItemsActivity.class, __md_methods);
	}


	public ListItemsActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ListItemsActivity.class)
			mono.android.TypeManager.Activate ("NewGroceryApp.ListItemsActivity, NewGroceryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
