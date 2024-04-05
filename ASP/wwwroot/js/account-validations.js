
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




let forms = document.querySelectorAll('form');


forms.forEach(form => {
   
    let inputs = form.querySelectorAll('input, textarea');

   
    inputs.forEach(input => {
       
        if (input.dataset.val === 'true') {
           
            if (input.type === 'text' || input.type === 'email' ||  {
                input.addEventListener('keyup', (e) => {
                    switch (e.target.type) {
                        case 'text':
                            textValidator(e.target);
                            break;
                        case 'email':
                            emailValidator(e.target);
                            break;
                        
                    }
                });
            }
        }
    });
});