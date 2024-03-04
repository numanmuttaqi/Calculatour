using System;

using AppKit;
using Foundation;

namespace Calculatour
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

		int step = 0;
		int num1;
		int num2;

        partial void PushButton(NSButton sender)
        {
			int num1 = Convert.ToInt16(TextInput.StringValue);
			int num2 = Convert.ToInt16(TextInput2.StringValue);

			if(selected == 0)
			{
				SetText(Convert.ToString(num1 + num2));
			}
            else if (selected == 1)
            {
                SetText(Convert.ToString(num1 - num2));
            }
            else if (selected == 2)
            {
                SetText(Convert.ToString(num1 * num2));
            }
            else if (selected == 3)
            {
                SetText(Convert.ToString(num1 / num2) + " remainder " + Convert.ToString(num1 % num2));
            }
            TextInput.StringValue = "";
            TextInput2.StringValue = "";
        }

		private void SetText(string text)
		{
			InfoLabel.StringValue = text;
		}

		int selected = 0;

        partial void AddAction(NSButton sender)
        {
			SetRadio(AddOutlet);
			selected = 0;
        }
        partial void SubstractAction(NSButton sender)
        {
            SetRadio(SubstractOutlet);
            selected = 1;
        }
        partial void MultiplyAction(NSButton sender)
        {
            SetRadio(MultiplyOutlet);
			selected = 2;
        }
        partial void DivideAction(NSButton sender)
        {
            SetRadio(DivideOutlet);
            selected = 3;
        }

        public void SetRadio(NSButton selected)
		{
			AddOutlet.State = NSCellStateValue.Off;
            SubstractOutlet.State = NSCellStateValue.Off;
            MultiplyOutlet.State = NSCellStateValue.Off;
            DivideOutlet.State = NSCellStateValue.Off;

            selected.State = NSCellStateValue.On;
        }
    }
}
