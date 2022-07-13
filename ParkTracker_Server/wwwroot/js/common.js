window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, 'TOASTR SUCCESS MESSAGE!!!');
    } else if
    (type === "error") {
        toastr.error(message, "ERROR MESSAGE FROM TOASTR!!!");
    }
}