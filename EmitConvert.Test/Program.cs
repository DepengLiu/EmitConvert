﻿using EmitConvert.Test.Test;
using JQ.EmitConvert;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmitConvert.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeTimer.Time("EmitObjectToParamTest_1", 1, new EmitObjectToParamTest());
            CodeTimer.Time("EmitObjectToParamTest_100000", 100000, new EmitObjectToParamTest());
            CodeTimer.Time("EmitObjectToParamTest_100000", 100000, new EmitObjectToParamTest());
            CodeTimer.Time("EmitObjectToParamTest_100000", 100000, new EmitObjectToParamTest());
            CodeTimer.Time("EmitObjectToParamTest_100000", 100000, new EmitObjectToParamTest());
            CodeTimer.Time("EmitObjectToParamTest_100000", 100000, new EmitObjectToParamTest());
            CodeTimer.Time("EmitObjectToParamTest_100000", 100000, new EmitObjectToParamTest());
            CodeTimer.Time("EmitObjectToParamTest_100000", 100000, new EmitObjectToParamTest());
            CodeTimer.Time("EmitObjectToParamTest_100000", 100000, new EmitObjectToParamTest());
            CodeTimer.Time("EmitObjectToParamTest_100000", 100000, new EmitObjectToParamTest());

            CodeTimer.Time("EmitToTableTest_10000", 10000, new EmitTableToListTest());
            CodeTimer.Time("PropertyReflectUtilTableToListTest_10000", 10000, new PropertyReflectUtilTableToListTest());

            CodeTimer.Time("EmitToTableTest_50000", 50000, new EmitTableToListTest());
            CodeTimer.Time("PropertyReflectUtilTableToListTest_50000", 50000, new PropertyReflectUtilTableToListTest());

            CodeTimer.Time("EmitToTableTest_100000", 100000, new EmitTableToListTest());
            CodeTimer.Time("PropertyReflectUtilTableToListTest_100000", 100000, new PropertyReflectUtilTableToListTest());

            CodeTimer.Time("EmitRowToEntityTest_10000", 10000, new EmitTableToListTest());
            CodeTimer.Time("PropertyReflectUtilRowToEntityTest_10000", 10000, new PropertyReflectUtilTableToListTest());

            CodeTimer.Time("EmitRowToEntityTest_50000", 50000, new EmitTableToListTest());
            CodeTimer.Time("PropertyReflectUtilRowToEntityTest_50000", 50000, new PropertyReflectUtilTableToListTest());

            CodeTimer.Time("EmitRowToEntityTest_100000", 100000, new EmitTableToListTest());
            CodeTimer.Time("PropertyReflectUtilRowToEntityTest_100000", 100000, new PropertyReflectUtilTableToListTest());

            Console.ReadKey();
        }
    }
}
