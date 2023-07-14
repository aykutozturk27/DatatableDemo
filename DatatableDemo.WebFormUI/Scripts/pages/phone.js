$(document).ready(function () {
    $("#phoneTable").DataTable({
        "processing": true,
        "serverSide": true,
        "filter": true,
        "ordering": true,
        "ajax": {
            "url": "Phone.aspx/GetData",
            "contentType": "application/json",
            "type": "GET",
            "dataType": "JSON",
            "data": function (d) {
                return d;
            },
            "dataSrc": function (json) {
                json.draw = json.d.draw;
                json.recordsTotal = json.d.recordsTotal;
                json.recordsFiltered = json.d.recordsFiltered;
                json.data = json.d.data;
                var return_data = json.d.data;
                return return_data;
            }
        },
        "columnDefs": [
            {
                "targets": [4],
                "render": function (data) {
                    return moment(data).format('DD/MM/YYYY HH:mm');
                }
            }
        ],
        "columns": [
            { "data": "FirstName" },
            { "data": "LastName" },
            { "data": "Message" },
            { "data": "PhoneNumber" },
            { "data": "CreatedOn" },
            { "data": "CreatedBy" }
        ]
    });
});
