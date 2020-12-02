
using System;
using System.Collections.Generic;
namespace DeepSpace
{

	class Estrategia
	{
		
		
		public String Consulta1( ArbolGeneral<Planeta> arbol)
		{
			return "Implementar";
		}


		public String Consulta2( ArbolGeneral<Planeta> arbol)
		{
			return "Implementar";
		}


		public String Consulta3( ArbolGeneral<Planeta> arbol)
		{
			Cola<ArbolGeneral<Planeta>> planeta = new Cola<ArbolGeneral<Planeta>>() ; 
			planeta.encolar(arbol) ; 
			int lv = 0 ; 
			string ms = "" ; 
			while(!planeta.esVacia()) {
				int elem = planeta.cantElementos ; 
				lv++ ;
				int cantNivel = 0 ; 
				int poblacionPorLv = 0 ; 
				while (elem-- > 0 ) {
					Cola<ArbolGeneral<Planeta> nodoActual = planeta.desencolar	
				}
			}
			return "Implementar";
		}
		
		public Movimiento CalcularMovimiento(ArbolGeneral<Planeta> arbol)
		{
			//Implementar
			
			return null;
		}
	}
}
