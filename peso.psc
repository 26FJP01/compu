Algoritmo Leccion09
	definir pesoManzana,pesoTotal como entero
	//inicializar la variable
	pesoTotal=0//acumilador
	Mientras pesoTotal<=1000 Hacer
		escribir"ingrese el peso de la manzana comprada:"
		leer pesoManzan
		Si pesoManzana>=180 Entonces
			pesoTotal=pesoTotal+PesoManzana
			escribir"Llevo en total de peso",pesoTotal
		SiNo
			
			escribir"Error:La Manzana debe pesar al menos 180 gramos"
		Fin Si
	Fin Mientras
	escribir"Ya alcanzo o supero 1 kilo de Manzanas!!"
FinAlgoritmo
