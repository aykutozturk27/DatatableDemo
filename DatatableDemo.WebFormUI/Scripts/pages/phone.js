var phoneList = function () {
    var initTable = function () {
        var phoneTable = $("#phoneTable");
        phoneTable.DataTable({
            "processing": true,
            "serverSide": true,
            "ajax": {
                "url": "Phone.aspx/GetData",
                "contentType": "application/json",
                "type": "POST",
                "dataType": "JSON",
                "data": function (d) {
                    var result = JSON.stringify({ model: d });
                    return result;
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
                { "data": "FirstName", "name": "FirstName" },
                { "data": "LastName", "name": "LastName" },
                { "data": "Message", "name": "Message" },
                { "data": "PhoneNumber", "name": "PhoneNumber" },
                { "data": "CreatedOn", "name": "CreatedOn" },
                { "data": "CreatedBy", "name": "CreatedBy" }
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
