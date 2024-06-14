class Prueba {
  //  privada
  #_salida;

  // Haemos el constructor que recibe 3 parámetros
  constructor(param1, param2, param3) {
    if (typeof param1 !== 'string') {
      throw new TypeError('El primer parámetro debe ser una cadena de caracteres');
    }
    if (!Number.isInteger(param2)) {
      throw new TypeError('El segundo parámetro debe ser un entero');
    }
    if (typeof param3 !== 'boolean') {
      throw new TypeError('El tercer parámetro debe ser un booleano');
    }

    const numeroParametros = 3; 
    this.#_salida = `Salida ${numeroParametros}: ${param1} ${param2} ${param3}.`;
  }

  // Propiedad para obtener el valor de _salida
  get salida() {
    return this.#_salida;
  }

  // Propiedad para asignar el valor de _salida
  set salida(valor) {
    this.#_salida = valor;
  }
}


const prueba = new Prueba('cadena', 42, true);
console.log(prueba.salida); 
prueba.salida = 'nuevo valor';
console.log(prueba.salida); 
//
// "Salida 3: cadena 42 true."
// "nuevo valor"