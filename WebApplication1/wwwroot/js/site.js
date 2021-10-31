// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

google.charts.load("current", { packages: ["corechart"] });
google.charts.setOnLoadCallback(drawChart);
function drawChart() {
    var data = google.visualization.arrayToDataTable([
        ['Task', 'Hours per Day'],
        ['Checkin', 11],
        ['Checkout', 2],
        ['Pendente', 2],
        ['Cancelado', 2],

    ]);

    var options = {
        title: 'Gráfico de Percentual de Atendimento',
        is3D: true,
        colors: ['green', 'blue', 'gray', 'red']
    };

    var chart = new google.visualization.PieChart(document.getElementById('piechart_3d'));
    chart.draw(data, options);
}


//Para data e hora



function time() {
    today = new Date();
    h = today.getHours();
    m = today.getMinutes();
    s = today.getSeconds();
    dayName = new Array("domingo", "segunda", "terça", "quarta", "quinta", "sexta", "sábado")
    monName = new Array("janeiro", "fevereiro", "março", "abril", "maio", "junho", "agosto", "outubro", "novembro", "dezembro")
    now = new Date
    document.getElementById('dataehora').innerHTML = "<h3>Agenda do Suporte - " + dayName[now.getDay()] + ", " + now.getDate() + " de " + monName[now.getMonth()] + " de " + now.getFullYear() + ", " + h + ":" + m + ":" + s + ". </h3>";
    setTimeout('time()', 500);
}


    
    
