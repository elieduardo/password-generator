function gerarSenha(type) {
    const url = new URL(
        "http://" + process.env.API_URL + "/api/values/" + type
    );

    fetch(url, {
        method: "GET",
    })
        .then(response => response.json())
        .then(json => $('#senha').val(json));
}