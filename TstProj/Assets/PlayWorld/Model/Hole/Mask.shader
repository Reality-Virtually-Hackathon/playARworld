﻿
Shader "Custom/Mask" {
 
   SubShader {

      Tags
      {
        
         "Queue" = "Geometry - 1"
      }
        
         ZWrite On
 
         ColorMask 0
 
         Pass {}
   }
}