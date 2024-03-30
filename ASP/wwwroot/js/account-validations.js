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


const postalCodeValidator = (element) => {
    const regEx = /^\d{5}(?:[-\s]\d{4})?$/;
    formErrorHandler(element, regEx.test(element.value))
}

const phoneValidator = (element) => {
    const regEx = /^\d{10}$/;
    formErrorHandler(element, regEx.test(element.value))
}


let forms = document.querySelectorAll('form');

// Loop through each form
forms.forEach(form => {
    // Get all inputs and textareas in the current form
    let inputs = form.querySelectorAll('input, textarea');

    // Loop through each input
    inputs.forEach(input => {
        // Check if input has validation enabled
        if (input.dataset.val === 'true') {
            // Attach appropriate event listeners based on input type
            if (input.type === 'text' || input.type === 'email' || input.type === 'tel' || input.type === 'postal') {
                input.addEventListener('keyup', (e) => {
                    switch (e.target.type) {
                        case 'text':
                            textValidator(e.target);
                            break;
                        case 'email':
                            emailValidator(e.target);
                            break;
                        case 'tel':
                            phoneValidator(e.target);
                            break;
                        case 'postal':
                            postalCodeValidator(e.target);
                            break;
                    }
                });
            }
        }
    });
});