var userFactor = (function ($) {


    var Items=[];
    var getItems = function (index) {
        return Items[index];
    }

    var SetGetItems = function (index) {


        $.ajax({
            type: "POST",
            dataType: "json",
            url: '/UserFactor/GetUser/',
            data: { 'index': index },
            success: function (data) {
                Items[index] = data;  
                setUsers(index);
            }
        });
    }

    var changeActor = function () {
        if (undefined == getItems(this.value)) {
            SetGetItems(this.value);
        }
        else {
            setUsers(this.value);
        }
    }

    var setUsers = function (index) {
        var listUser = getItems(index);

        $("#user").empty();

        $("#user").append("<option selected='selected' value=''>انتخاب کنید</option>");
        $.each(listUser, function (key, value) {
            $("#user").append("<option value=" + value.id+">" + value.name+"</option>")
        });        
    }


    var fillTableFactor = function () {
        var actorId = $("#Actor").val();
        var userId = $('#user').val();
        var fromDate = $('#fromDate').val();
        var toDate = $('#toDate').val();
        if (actorId != null && userId != null) {
            $("#loading").show(100);
            $.ajax({
                type: "POST",
                dataType: "json",
                url: '/UserFactor/GetUserFactor/',
                data: { 'actorId': actorId, 'userId': userId, 'fromDate': fromDate, 'toDate': toDate },
                success: function (data) {
                    $("#factorBodyTable").empty();

                    $.each(data, function (key, value) {
                        $("#factorBodyTable").append("<tr><td>" + (key + 1) + "</td><td>" + value.code + "</td><td>" +
                            value.dateFa + "</td><td>" + value.time + "</td><td>" +
                            value.comment + "</td><td>" + value.airConditionerModelName + "</td><td>" +
                            value.engineVolumeName + "</td><td>" + value.userExpertName + "</td><td>" +
                            value.userOperatorName + "</td><td>" + value.userTechnicianName + "</td><td>" +
                            value.userAssistantName + "</td><td>" + value.customerName + "</td></tr>");
                    });

                    $("#loading").hide(100);
                }
            });
        } else {
            alert("لطفا موارد خواسته شده را پر نمایید.")
        }  
    }


   
    var bindEvents = function () {       
        $("#Actor").on("change", changeActor);
        $("#search").on("click", fillTableFactor);
    }

    $(function () {       
        bindEvents();
    });

    return {
      
    }

}(jQuery));
