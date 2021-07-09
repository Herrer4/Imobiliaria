// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var dataTable;

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {    
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/Imovel/GetAll/",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "descricao", "width": "20%" },
            { "data": "quantidadeDeQuartos", "width": "20%" },
            { "data": "cidade", "width": "20%" },
            { "data": "bairro", "width": "20%" },
            { "data": "tipoImovelLabel", "width": "20%" },
            { "data": "valorAluguel", "width": "20%" }            
        ],
        "language": {
            "emptyTable": "no data found"
        },
        "width": "100%"
    })
}