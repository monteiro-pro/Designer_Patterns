﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BuilderAndroid : ICelular
    {
        public Celular celular;

        public BuilderAndroid()
        {
            this.celular = new Celular("Android");
        }

        public void BuildBateria()
        {
            celular.Bateria = "HMP 200";
        }

        public void BuildCamera()
        {
            celular.Camera = "12 MP";
        }

        public void BuildSistema()
        {
            celular.Sistema = "Android 8.1";
        }

        public void BuildTela()
        {
            celular.Tela = "6";
        }

        public Celular Celular
        {
            get { return this.celular; }
        }
    }
}
