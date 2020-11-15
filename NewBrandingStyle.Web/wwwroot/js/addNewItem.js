(function () {
    const alertElement = document.getElementById("success-alert");
    const buttons = document.getElementById("buttons");
    const formElement = document.forms[0];

    const addNewItem = async () => {
        const name = formElement.querySelector('#Name').value;
        const description = formElement.querySelector('#Description').value;
        const isVisible = formElement.querySelector('#IsVisible').checked;

        const data = {
            Name: name,
            Description: description,
            IsVisible: isVisible
        };

        const requestData = {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(data)
        };

        const responseFetch = await fetch('/api/Ajax/AddItem', requestData);
        if (responseFetch.ok) {
            alertElement.style.display = 'block';
        }
    };
    buttons.addEventListener("click", () => {
        event.preventDefault();
        addNewItem().then(() => console.log("added successfully"));
    });
})();