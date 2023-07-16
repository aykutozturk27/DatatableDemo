var phoneList = function () {
    var initTable = function () {
        var phoneTable = $("#phoneTable");
        phoneTable.DataTable({
            "processing": true,
            "serverSide": true,
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
                { "data": "FirstName", "searchable": true },
                { "data": "LastName", "searchable": true },
                { "data": "Message", "searchable": true },
                { "data": "PhoneNumber", "searchable": true },
                { "data": "CreatedOn", "searchable": true },
                { "data": "CreatedBy", "searchable": true }
            ]
        });

    }

    var handleEvents = function () {

    }

    return {
        init: function () {
            initTable();
            handleEvents();
        }
    }
}();

$(document).ready(function () {
    phoneList.init();
});
