﻿/*
Copyright (c) 2018-2021 Festo AG & Co. KG <https://www.festo.com/net/de_de/Forms/web/contact_international>
Author: Michael Hoffmeister

This source code is licensed under the Apache License 2.0 (see LICENSE.txt).

This source code may use other Open Source software components (see LICENSE.txt).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AasxPluginSmdExporter
{
    public class SummingPoint
    {

        public List<IOput> inputs { get; set; }

        public IOput output { get; set; }

        public string Name { get; set; }

        public AdminShellNS.AdminShell.SemanticId SemanticId { get; set; }
        public SummingPoint()
        {
            inputs = new List<IOput>();
        }

        public SummingPoint(IOput output, string name, AdminShellNS.AdminShell.SemanticId semanticId)
        {
            this.output = output;
            this.Name = name;
            this.SemanticId = semanticId;
            inputs = new List<IOput>();
        }

        /// <summary>
        /// Returns the summingpoint as a Simualationmodel
        /// </summary>
        /// <returns></returns>
        public SimulationModel GetAsSimulationModel()
        {
            SimulationModel simulationModel = new SimulationModel();
            simulationModel.Inputs = this.inputs;
            simulationModel.Outputs.Add(this.output);
            simulationModel.Name = this.Name;
            simulationModel.SemanticId = this.SemanticId;
            return simulationModel;
        }
    }
}
