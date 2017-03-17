using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testWebApi.Models
{
    public class TestNonCommit
    {
        private String javaStyleName;
        private Int32 javaStyleNumber;

        public String getJavaStyleName()
        {
            return javaStyleName;
        }
        public Int32 getJavaStylNumber()
        {
            return javaStyleNumber;
        }
        public void setJavaStyleName(String javaStyleName)
        {
            this.javaStyleName = javaStyleName;
        }
        public void getJavaStylNumber(Int32 javaStyleNumber)
        {
            this.javaStyleNumber = javaStyleNumber;
        }
    }
}