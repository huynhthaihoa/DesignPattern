using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class SimpleProductFacade
    {
        private DifficultProduct difficultproduct;
        public SimpleProductFacade()
        {
            difficultproduct = new DifficultProduct();
        }
        public void setName(string n)
        {
            char[] chars = n.ToCharArray();
            if (chars.Length > 0)
            {
                difficultproduct.setFirstNameCharacter(chars[0]);
            }
            if (chars.Length > 1)
            {
                difficultproduct.setSecondNameCharacter(chars[1]);
            }
            if (chars.Length > 2)
            {
                difficultproduct.setThirdNameCharacter(chars[2]);
            }
            if (chars.Length > 3)
            {
                difficultproduct.setFourthNameCharacter(chars[3]);
            }
            if (chars.Length > 4)
            {
                difficultproduct.setFifthNameCharacter(chars[4]);
            }
            if (chars.Length > 5)
            {
                difficultproduct.setSixthNameCharacter(chars[5]);
            }
            if (chars.Length > 6)
            {
                difficultproduct.setSeventhNameCharacter(chars[6]);
            }
        }
        public string getName()
        {
            return difficultproduct.getName();
        }
    }
}
