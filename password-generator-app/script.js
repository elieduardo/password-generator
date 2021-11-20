function gerarSenha(type) {
    const url = new URL(
        "http://127.0.0.1:5000/api/values/" + type
    );

    fetch(url, {
        method: "GET",
    })
        .then(response => response.json())
        .then(json => $('#senha').val(json));
}