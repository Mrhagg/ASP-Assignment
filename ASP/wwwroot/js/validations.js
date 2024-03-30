console.log('inne')

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


const textValidator = (element, minLength = 2) => {
  
    if (element.value.length >= minLength) {
        formErrorHandler(element, true)
    }
    else {
        formErrorHandler(element, false)
    }
}

const emailValidator = (element) => {
    const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*[@.])(.{8,})$/;
    formErrorHandler(element, regEx.test(element.value))
}

const passwordValidator = (element) => {
    if (element.dataset.valEqualtoOther !== undefined) {
        let password = document.getElementsByName(element.dataset.valEqualtoOther.replace('*', 'Form'))[0].value

        if (element.value === password)
            formErrorHandler(element, true)

        else
            formErrorHandler(element, false)
    }
    else {
        const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+{}|:\"<>?]).{6,}$/
        formErrorHandler(element, regEx.test(element.value))
    }
}

const postalCodeValidator = (element) => {
    const regEx = /^\d{5}(?:[-\s]\d{4})?$/;
    formErrorHandler(element, regEx.test(element.value))
}

const phoneValidator = (element) => {
    const regEx = /^\d{10}$/; 
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
    
                        case 'text':
                            textValidator(e.target)
                            break;
    
                        case 'email':
                            emailValidator(e.target)
                            break;
    
                        case 'password':
                            passwordValidator(e.target)
                            break;

                        case 'postal':
                        postalCodeValidator(e.target)
                        break;

                        case 'tel':
                        phoneValidator(e.target)
                         break;
                    }
                })
            }
        }
    })
})