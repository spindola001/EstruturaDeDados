using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EstruturaDeDados.Array
{
    public class ArrayExercicios
    {
        public string[] arrayStringExample { get; set; }
        public int[] arrayIntegerExample { get; set; }

        public ArrayExercicios()
        {
            arrayIntegerExample = [0, 20, 19, 4, 6, 14, 10];
            arrayStringExample = ["Zebral", "Evelyn", "Marcos", "Cecília", "Zebra", "Salsicha", "João", "Zacarias", "Thomas"];
        }

        /// <summary>
        /// Linear Search - String Data
        /// </summary>
        /// <param name="arrayStringExample"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public int LinearSearchAlgStringData(string[] arrayStringExample, string filter)
        {
            for (int i = 0; i < arrayStringExample.Length; i++)
            {
                if (arrayStringExample[i].Equals(filter, StringComparison.InvariantCultureIgnoreCase))
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Insertion Sort - String Data
        /// Complexidade de Tempo: O(n²) no caso médio e pior caso, O(n) no melhor caso.
        ///     - Em um caso onde o Array está em ordem decrescente, o loop for irá comparar cada elemento com seus elementos anteriores.
        /// Complexidade de Espaço: O(1)
        /// </summary>
        /// <param name="arrayStringExample"></param>
        /// <returns></returns>
        public string[] InsertionSortAlgStringData(string[] arrayStringExample)
        {
            string aux;
            int j;

            for (int i = 1; i < arrayStringExample.Length; i++)
            {
                aux = arrayStringExample[i];
                j = i - 1;

                while (j >= 0 && string.Compare(arrayStringExample[j], aux, StringComparison.InvariantCultureIgnoreCase) > 0)
                {
                    arrayStringExample[j + 1] = arrayStringExample[j];
                    j--;
                }

                arrayStringExample[j + 1] = aux;
            }

            return arrayStringExample;
        }

        /// <summary>
        /// Linear Search - Int Data
        /// </summary>
        /// <param name="arrayIntegerExample"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public int LinearSearchAlgIntegerData(int[] arrayIntegerExample, int filter)
        {
            for (int i = 0; i < arrayIntegerExample.Length; i++)
            {
                if (arrayIntegerExample[i] == filter)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Insertion Sort - Int Data
        /// Complexidade de Tempo: O(n²) no caso médio e pior caso, O(n) no melhor caso.
        ///     - Em um caso onde o Array está em ordem decrescente, o loop for irá comparar cada elemento com seus elementos anteriores.
        /// Complexidade de Espaço: O(1)
        /// </summary>
        /// <param name="arrayIntegerExample"></param>
        /// <returns></returns>
        public int[] InsertionSortAlgIntegerData(int[] arrayIntegerExample)
        {
            int aux, j;

            for (int i = 1; i < arrayIntegerExample.Length; i++)
            {
                aux = arrayIntegerExample[i];
                j = i - 1;

                while (j >= 0 && arrayIntegerExample[j] > aux)
                {
                    arrayIntegerExample[j + 1] = arrayIntegerExample[j];
                    j--;
                }

                arrayIntegerExample[j + 1] = aux;
            }

            return arrayIntegerExample;
        }


    }
}
