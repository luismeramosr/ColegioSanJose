using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Datalib
{
    public class JSON
    {
        public string jsonString;
        public JsonConverter converter;

        public JSON()
        {
            string json = @"{
                'descripcion': 'insert description here',
                'nombre': 'some name',
                'tiempo': 150,
                'preguntas': [
                    {'enunciado': 'Un enunciado', 'alternativas': [
                        {'descripcion': 'adsasaa', 'isSelected': false}
                    ]}
                ]
            }";
        }
    }
}
