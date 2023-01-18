function validateInput() {
    if (document.getElementById("uploadBox").value == "") {
        Swal.fire(
            'Ошибка!',
            'Пожалуйста загрузите картинку!',
            'error'
        )
        return false;
    }
    return true;
}