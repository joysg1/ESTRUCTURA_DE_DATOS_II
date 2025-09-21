import java.util.Scanner;
import java.util.Arrays;

public class Quicksort {

	public static void quicksort(int vector[], int inicio, int fin) {
		//Pasos bases 
		if (vector == null || vector.length == 0) {  
			return;}

		if (inicio >= fin) {
			return;}
		//recursivo
	    
		//Encontrar punto medio
		int medio = inicio + (fin - inicio)/2;
		
		//Encontrar pivote en base al punto medio
		int pivote = vector[medio];
		
		int izq= inicio;
		int der= fin;
		
		while(izq<=der) {
		
		while(vector[izq]<pivote) {
			
			izq = izq +1;
		}
		
		while(vector[der]>pivote) {
			der = der -1;
		}
		
		if(izq<=der) {
			
			int aux = vector[izq];
			vector[izq]=vector[der];
			vector[der]=aux;
			der=der-1;
			izq=izq+1;
		}
		}//fin while mas externo
		
		if(inicio<der) {
			quicksort(vector,inicio,der);
		}
		
		if(fin>izq) {
			quicksort(vector,izq,fin);
		}
		
		

	}
	
	

	public static void main(String[] args) {
		int tam=2;
		int busq=0;
		int j=0;
		int c=0;
		char selec='s';
		
		Scanner data = new Scanner(System.in);
		System.out.println("                 QUICKSORT");
		System.out.println("");
		
		try {
		do {
		System.out.println("Ingrese la magnitud del arreglo ha evaluar: ");
		tam = data.nextInt();
		}while(tam<=0);
		}
		catch(Exception e) {
			System.out.println("Dato no valido");
			System.exit(0);
		}
		int ord [] = new int [tam];
		System.out.println("");
		
		for(int i=0 ; i<ord.length; i++) {
			System.out.println("Ingrese el valor #" +(i+1) + " del vector: ");
			ord[i]=data.nextInt();
		}
		
		System.out.println("\t\t\tVector desordenado");
		System.out.println("");
		
		System.out.println(Arrays.toString(ord));
		System.out.println("");
		
		int desde =0;
		int hasta = ord.length -1;
		
		quicksort(ord,desde,hasta);
		System.out.println("\t\t\tResultado final");
		System.out.println("");
		System.out.println(Arrays.toString(ord));
		System.out.println("");
		System.out.println("        BUSQUEDA");
		
		
		do {
		try {
		System.out.println("Ingrese el elemento a buscar dentro del arreglo: ");
		busq= data.nextInt();
		}
		catch(Exception e) {
			System.out.println("Dato no valido\n");
			System.exit(0);
		}
		for(j=0; j<ord.length;j++) {
			
			if(ord[j]==busq) {
				System.out.println("Valor encontrado");
				System.out.println("");
				System.out.println("Posicion del valor encontrado: "+ (j+1));
				System.out.println("");
			}
			else if(ord[j]!=busq) {
				c= c+1;
				
			}
			
			
			
		}
		if(c>=ord.length) {
			System.out.println("Valor no encontrado");
			System.out.println("");
			c=0;
		}
		System.out.println("Presione N para salir del programa");
		System.out.println("Presione cualquier otra tecla para iniciar una nueva busqueda ");
		selec=data.next().charAt(0);
		}while(selec!='n' && selec!='N');
		System.out.println("");
		System.out.println("Gracias por utilizar el programa");
		
		
 
	}

}