
//var datasource = new kendo.datasource

function formatDate(d)
{
    var myDate = new Date(moment(d));
    var formattedDate = (myDate.getMonth() + 1) + '/' + myDate.getDate() + '/' + myDate.getFullYear();

    return formattedDate;
}

//JIMMY'S JS FOR DATE WITH PADDING
//function pad(d)
//{
//    return (d < 10) ? '0' + d.toString() : d.toString();
//}

//var myDate = new Date(1375531964000);
//var formattedDate = (pad(myDate.getMonth() + 1)) + '/' + pad(myDate.getDate()) + '/' +  myDate.getFullYear();

//alert(formatted)