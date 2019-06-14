/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {

        static void Main()
        {
            /* Properties look like fields from the outside, but
             internally they contain logic, like methods do. For
             example, you can't tell by looking at the following 
             code whether CurrentPrice is a field or a property: */
            Stock msft = new Stock();
            msft.CurrentPrice = 30;
            msft.CurrentPrice -= 3; 
            Console.WriteLine (msft.CurrentPrice);
        }
    }
    /* A property is declared like a field, but with a get/set block
    added. Here's how to implement CurrentPrice as a property: */

    /* Although properties are accessed in the same way as fields, 
     they differ in that they give the implementer complete control
     over getting and setting its value. This control enables the 
     implementer to choose whatever internal representation is 
     needed, without exposing the internal details to the user of
     the property. In the example below, the set method could throw an
     exception if value was outside a valid range of values. */
    /* In a real application, you would typically favor public 
     properties over public fields, in order to promote encapsulation. */
    /* Properties have the following modifiers: 
     
       Static modifier:             static
       Access modifiers:            public, internal, private, protected
       Inheritance modifiers:       new, virtual, abstract, override, sealed
       Unmanaged code modifiers:    unsafe, extern    */


    public class Stock
    {
        
        decimal currentPrice, sharesOwned;           // The private "banking" field
        public decimal CurrentPrice     // The public property
        {
            get { return currentPrice; }
            set { currentPrice = value; }

            /* get and set denote property accessors. The get accessor
             runs when the property is read. It must return a value of 
             the property's type. The set accessor runs when the 
             property is assigned. It has an implicit parameter named
             value of the property's type that you typically assign to
             a private field. (in this case, currentPrice).*/
        }
    }
}
