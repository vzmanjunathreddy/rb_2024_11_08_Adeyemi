using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class IceCream
    {
        private Guid _userId { get; set; }
        private IceCreamFlavour _flavour { get; set; }
        private IceCreamForm _form { get; set; }


        public IceCream(Guid userId, IceCreamFlavour flavour, IceCreamForm form) 
        { 
            _userId= userId;
            _flavour= flavour;
            _form = form;
        }

        private Guid Id { get; set; }
        private Guid UserId { get; set; }
        private IceCreamFlavour Flavour { get; set; }
        private IceCreamForm Form { get; set; }

        public IceCream CreateIceCream()
        {
            var result = new IceCream(Guid.NewGuid(), _flavour, _form);
            return result;
        }
    }



    enum IceCreamFlavour
    {
        Vanilla = 1,
        Chocolate = 2,
        Strawberry = 3,
    }

    enum IceCreamForm
    {
        Cone = 1,
        Cup = 2,
        Sundae = 3,
    }

    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }


        //private Guid _userId { get; set; }
        //private IceCreamFlavour _flavour { get; set; }
    }
}
