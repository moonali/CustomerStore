$(document).ready(function () {
    var Id = $("#Id").val();
    Status(Id);
});
function Status(id) {
    $.ajax({
        url: "https://localhost:44355/Customer/CustomerStatus/" + id,
        type: 'GET',
        dataType: 'json', // added data type
        success: function (res) {
            if (!res.status) {

                var CheckCustomerRoute = $("#customerDetailsId").val();
                var CustomerButton = "";
                if (CheckCustomerRoute) {
                    CustomerButton = "Activate your Status: <input id='status-change' onclick='changeStatus()' value='" + res.status + "' type='checkbox' />";
                } else {
                    CustomerButton = " <button  onclick ='redirctToEditPage(" + res.id + ")' class='btn btn-primary'>Edit</button>";
                }
                var errorMsg = res.customerName + " Status is currently Inactive <br><br>" + CustomerButton;
                $('#myModal').modal('show');
                $('#myModal .modal-body #errorMessge').html(errorMsg);
            }

        }
    });
}
function redirctToEditPage(id) {
     window.location.replace("https://localhost:44355/Customer/EditCustomer/" + id);
}
function changeStatus() {
    if ($('#status-change').is(":checked")){
        $("#Status").attr('checked', true);
        $(".form-check-label").css('color', 'green');
    } else {
        $("#Status").attr('checked', false);
        $(".form-check-label").css('color', 'red');
    }
}