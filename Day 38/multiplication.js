function printTable() {
  var number = parseInt(document.getElementById('numberInput').value);
  var table = document.getElementById('tableOutput');
  
  // Clear previous table content
  table.innerHTML = '';
  
  // Create table header
  var headerRow = table.insertRow(0);
  var headerCell = headerRow.insertCell(0);
  headerCell.innerHTML = 'Number';
  headerCell.classList.add('header-cell');
  
  for (var i = 1; i <= 10; i++) {
    headerCell = headerRow.insertCell(i);
    headerCell.innerHTML = 'x ' + i;
    headerCell.classList.add('header-cell');
  }
  
  // Create table rows
  for (var i = 1; i <= 10; i++) {
    var row = table.insertRow(i);
    var numberCell = row.insertCell(0);
    numberCell.innerHTML = number + ' x ' + i;
    numberCell.classList.add('number-cell');
    
    for (var j = 1; j <= 10; j++) {
      var cell = row.insertCell(j);
      cell.innerHTML = number * j;
      cell.classList.add('data-cell');
    }
  }
}
