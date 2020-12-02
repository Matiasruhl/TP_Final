
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
			Cola<ArbolGeneral<Planeta>> cola = new Cola<ArbolGeneral<Planeta>>() ; 
			cola.encolar(arbol) ; 
			int lv = 0 ; 
			string ms = "" ; 
			while(!cola.esVacia()) {
				int elem = planeta.cantElementos ; 
				lv++ ;
				int cantNivel = 0 ; 
				int poblacionPorLv = 0 ; 
				while (elem-- > 0 ) {
					Cola<ArbolGeneral<Planeta> nodoActual = cola.desencolar() ; 
					cantNivel++ ; 
					poblacionPorLv += nodoActual.getDatoRaiz().Poblacion(); 
					
  					foreach ( Cola<ArbolGeneral<Planeta>> nodoHijo in nodoActual.getHijos() ) {
						cola.encolar(hijo) ; 
					}
				}
				ms += "Nivel " + lv + ": " + poblacionPorLv/cantNivel + ".";
			}
			return ms ;
		}
		
		public Movimiento CalcularMovimiento(ArbolGeneral<Planeta> arbol)
		{
			//Implementar
			
			return null;
		}
	}
}
