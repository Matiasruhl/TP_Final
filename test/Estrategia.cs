
using System;
using System.Collections.Generic;
namespace DeepSpace
{

	class Estrategia
	{
		
		
		public String Consulta1( ArbolGeneral<Planeta> arbol , ArbolGeneral<Planeta> nodoCercanoAlBot )
		{
			arbol.getDatoRaiz().EsPlanetaDeLaIA() ;
			nodoCercanoAlBot.
			Cola<ArbolGeneral<Planeta>> cola = new Cola<ArbolGeneral<Planeta>>() ;
			cola.encolar(Arbol) ;
			string ms = "" ;
			int distancia = 0 ;
			//recorrido por niveles 
			while ( !cola.esVacia() ) {
				Cola<ArbolGeneral<Planeta>> nodoActual = cola.desencolar() ; 
				
				if ( nodoActual =  ) {
					distancia++ ; 
				}	
					
			}
			ms += "La distancia entre la raiz del arbol y del nodo " + //NodoCercanoAlBot + "es de : " + distancia ; 
			return ms ; 
		}


		public String Consulta2( ArbolGeneral<Planeta> arbol)
		{
			Cola<ArbolGeneral<Planeta>> cola = new Cola<ArbolGeneral<Planeta>>() ; 
			cola.encolar(arbol) ; 
			int lv = 0 ; 
			string ms = "" ; 
			while(!cola.esVacia()) {
				int elem = cola.cantElementos ; 
				lv++ ;
				int cantidad = 0 ; 
				int poblacionPorLv = 0 ; 
				while (elem-- > 0 ) {
					Cola<ArbolGeneral<Planeta>> nodoActual = cola.desencolar() ; 
					
					if ( nodoActual.getDatoRaiz().Poblacion() > 10 ) {
						cantidad++ ;
					}
					foreach ( ArbolGeneral<Planeta> nodoHijo in nodoActual.getHijos() ) {
						cola.encolar(nodoHijo) ; 
					}
				}
				ms += "Nivel " + lv + ": " + cantidad + " ." ;
			}
			return ms ; 
		}


		public String Consulta3( ArbolGeneral<Planeta> arbol)
		{
			Cola<ArbolGeneral<Planeta>> cola = new Cola<ArbolGeneral<Planeta>>() ; 
			cola.encolar(arbol) ; 
			int lv = 0 ; 
			string ms = "" ; 
			while(!cola.esVacia()) {
				int elem = cola.cantElementos ; 
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
