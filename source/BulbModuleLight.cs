#region License
/* Bright Utilitarian Luminescent Beacon (BULB) 
 * Copyright ©  2014 Alshain, © 2020 Jiraiyah © 2023 [zer0Kerbal](http://github.com/zer0Kerbal)
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KSP;
using KSP.UI.Screens;
using KSP.Localization;
using UnityEngine;

namespace Bulb
{
    class BulbModule : PartModule
    {
        [KSPField(guiActive = true, guiName = "#autoLOC_6001402", isPersistant = true)]
        [UI_FloatRange(maxValue = 1, minValue = 0, scene = UI_Scene.Flight, stepIncrement = 0.05f)]
        protected float red = 0;

        [KSPField(guiActive = true, guiName = "#autoLOC_6001403", isPersistant = true)]
        [UI_FloatRange(maxValue = 1, minValue = 0, scene = UI_Scene.Flight, stepIncrement = 0.05f)]
        protected float green = 0;

        [KSPField(guiActive = true, guiName = "#autoLOC_6001404", isPersistant = true)]
        [UI_FloatRange(maxValue = 1, minValue = 0, scene = UI_Scene.Flight, stepIncrement = 0.05f)]
        protected float blue = 0;

        [KSPField(guiActive = false, isPersistant = true)]
        bool bulbColorRecorded = false;

        Light light;
        Renderer emissive;


        public override void OnAwake()
        {
            light = part.FindModelComponent<Light>();
            emissive = part.FindModelComponent<Renderer>();
        }

        public void Update()
        {
            if (HighLogic.LoadedSceneIsFlight)
                if (!bulbColorRecorded)
                    recordLightColor();
                else
                    setLightColor();
            //else if (HighLogic.LoadedSceneIsEditor)
                //recordLightColor();
        }

        public void recordLightColor()
        {
            if (light == null) return;
            red = light.color.r;
            green = light.color.g;
            blue = light.color.b;
            bulbColorRecorded = true;
        }

        public void setLightColor()
        {
            if (emissive == null || light == null) return;
            if (light.color.r != red || light.color.g != green || light.color.b != blue)
            {
                light.color = new Color(red, green, blue, 1);
                emissive.material.SetColor("_EmissiveColor", light.color);
            }
        }
    }
}