// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Calculatour
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton AddOutlet { get; set; }

		[Outlet]
		AppKit.NSButton DivideOutlet { get; set; }

		[Outlet]
		AppKit.NSTextField InfoLabel { get; set; }

		[Outlet]
		AppKit.NSButton MultiplyOutlet { get; set; }

		[Outlet]
		AppKit.NSButton SubstractOutlet { get; set; }

		[Outlet]
		AppKit.NSTextField TextInput { get; set; }

		[Outlet]
		AppKit.NSTextField TextInput2 { get; set; }

		[Action ("AddAction:")]
		partial void AddAction (AppKit.NSButton sender);

		[Action ("DivideAction:")]
		partial void DivideAction (AppKit.NSButton sender);

		[Action ("MultiplyAction:")]
		partial void MultiplyAction (AppKit.NSButton sender);

		[Action ("PushButton:")]
		partial void PushButton (AppKit.NSButton sender);

		[Action ("ResetButton:")]
		partial void ResetButton (AppKit.NSButton sender);

		[Action ("SubstractAction:")]
		partial void SubstractAction (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (InfoLabel != null) {
				InfoLabel.Dispose ();
				InfoLabel = null;
			}

			if (AddOutlet != null) {
				AddOutlet.Dispose ();
				AddOutlet = null;
			}

			if (SubstractOutlet != null) {
				SubstractOutlet.Dispose ();
				SubstractOutlet = null;
			}

			if (MultiplyOutlet != null) {
				MultiplyOutlet.Dispose ();
				MultiplyOutlet = null;
			}

			if (DivideOutlet != null) {
				DivideOutlet.Dispose ();
				DivideOutlet = null;
			}

			if (TextInput != null) {
				TextInput.Dispose ();
				TextInput = null;
			}

			if (TextInput2 != null) {
				TextInput2.Dispose ();
				TextInput2 = null;
			}
		}
	}
}
