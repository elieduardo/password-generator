function gerarSenha(type) {
    const url = new URL(
        "https://localhost:44308/api/values/" + type
    );

    fetch(url, {
        method: "GET",
    })
        .then(response => response.json())
        .then(json => $('#senha').val(json));
}