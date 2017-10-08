var ui = ui || {};

ui.common = {
  hideElement: function(id) {
    document.getElementById(id).style.display = "none"; 
  },
  showElement: function(id) {
    document.getElementById(id).style.display = "block"; 
  },
  setItemText: function(id, text){
    document.getElementById(id).innerHTML = text; 
  }
};