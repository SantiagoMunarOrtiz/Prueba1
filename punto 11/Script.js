
const jsonData = {
    "menu": {
      "id": "file",
      "value": "File",
      "popup": {
        "menuitem": [
          {"value": "New", "onclick": "CreateNewDoc()"},
          {"value": "Open", "onclick": "OpenDoc()"},
          {"value": "Close", "onclick": "CloseDoc()"}
        ]
      }
    }
  };
  
  // Recorrer los elementos del array 'menuitem' e imprimir sus valores
  jsonData.menu.popup.menuitem.forEach(item => {
    console.log(`Value: ${item.value}, Onclick: ${item.onclick}`);
  });
  