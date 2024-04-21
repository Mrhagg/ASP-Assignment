const formErrorHandler = (element, validationResult) => {
    let spanElement = document.querySelector(`[data-valmsg-for="${element.name}"]`)

    if (validationResult) {
        element.classList.remove('input-validation-error')
        spanElement.classList.remove('field-validation-error')
        spanElement.classList.add('field-validation-valid')
        spanElement.innerHTML = ''
    }
    else {
        element.classList.add('input-validation-error')
        spanElement.classList.add('field-validation-error')
        spanElement.classList.remove('field-validation-valid')
        spanElement.innerHTML = element.dataset.valRequired
    }
}

const emailValidator = (element) => {
    const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*[@.])(.{8,})$/;
    formErrorHandler(element, regEx.test(element.value))
}

const checkboxValidator = (element) => {
    if (element.checked)
        formErrorHandler(element, true)
    else
        formErrorHandler(element, false)
}


let forms = document.querySelectorAll('form')

forms.forEach(form => {
    let inputs = form.querySelectorAll('input, textarea')

    inputs.forEach(input => {
        if (input.dataset.val === 'true') {

            if (input.type === 'checkbox') {
                input.addEventListener('change', (e) => {
                    checkboxValidator(e.target)
                })
            }
            else {

                input.addEventListener('keyup', (e) => {

                    switch (e.target.type) {
                        case 'email':
                            emailValidator(e.target)
                            break;
                    }
                })
            }
        }
    })
})
