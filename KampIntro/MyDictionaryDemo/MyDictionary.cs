using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] _keyArray;
        Tkey[] _tempKeyArray;
        Tvalue[] _valueArray;
        Tvalue[] _tempKeyValue;
        public MyDictionary()
        {
            _keyArray = new Tkey[0];
            _valueArray = new Tvalue[0];
        }

        public void Add(Tkey tkey, Tvalue tvalue)
        {
            _tempKeyArray = _keyArray;
            _tempKeyValue = _valueArray;

            _keyArray = new Tkey[_keyArray.Length + 1];
            _valueArray = new Tvalue[_valueArray.Length + 1];


            for (int i = 0; i < _tempKeyArray.Length; i++)
            {
                _keyArray[i] = _tempKeyArray[i];
                _valueArray[i] = _tempKeyValue[i];

                Console.WriteLine(_keyArray[i]+" :"+_valueArray);
            }

            _keyArray[_keyArray.Length - 1] = tkey;
            _valueArray[_valueArray.Length + 1] = tvalue;

        }
        
    }
}
