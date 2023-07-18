// Get the modal element
const modal = document.getElementById('calculatorModal');

// Get the button that opens the modal
const openModalBtn = document.getElementById('openModalBtn');

// Get the <span> element that closes the modal
const closeModalSpan = document.getElementsByClassName('close')[0];

// When the user clicks the button, open the modal
openModalBtn.onclick = function () {
    modal.style.display = 'block';
};

// When the user clicks on <span> (x), close the modal
closeModalSpan.onclick = function () {
    modal.style.display = 'none';
};

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = 'none';
    }
};

// Handle the calculator form submission
const calculatorForm = document.getElementById('calculatorForm');
calculatorForm.onsubmit = function (event) {
    event.preventDefault(); // Prevent default form submission

    const startValue = parseInt(document.getElementById('start').value);
    const amount = parseInt(document.getElementById('amount').value);

    // Make the API call to perform the addition
    fetch(`api/calculator/add?start=${startValue}&amount=${amount}`)
        .then(response => response.json())
        .then(data => {
            // Display the result in the modal
            const resultElement = document.getElementById('result');
            resultElement.innerText = `Result: ${data}`;
        })
        .catch(error => console.error('Error:', error));
};

// Handle the "Subtract" button click (similar to the addition, modify the API URL)
const subtractBtn = document.getElementById('subtractBtn');
subtractBtn.onclick = function () {
    const startValue = parseInt(document.getElementById('start').value);
    const amount = parseInt(document.getElementById('amount').value);

    // Make the API call to perform the subtraction
    fetch(`api/calculator/subtract?start=${startValue}&amount=${amount}`)
        .then(response => response.json())
        .then(data => {
            // Display the result in the modal
            const resultElement = document.getElementById('result');
            resultElement.innerText = `Result: ${data}`;
        })
        .catch(error => console.error('Error:', error));
};
