using Gtk;

namespace Grasshoppers
{
    public partial class AddCharacter_Dialog : Dialog
    {
        public AddCharacter_Dialog() : this(new Builder("AddCharacter_Dialog.glade"))
        {
        }

        private AddCharacter_Dialog(Builder builder) : base(builder.GetObject("AddCharacter_Dialog").Handle)
        {
            builder.Autoconnect(this);
            InitializeComponents();
        }
    }
}