# Password generator
Nosso projeto foi realizado utilizando para construir a API C# + ASP.NETCORE, já no frontend utilizamos HTML+CSS+JS.

Criamos o repositório no Dockerhub.

Para criar a imagem utilizamos o Docker, construindo a imagem da API com:

```bash
docker build -t eduardoeli/pass-gen-api .
```

Para criar a imagem utilizamos o Docker, construindo a imagem do front com:

```bash
docker build -t eduardoeli/pass-gen-front .
```

Após isso, rodamos o comando abaixo para subir a imagem para o repositório:

```bash
docker push eduardoeli/pass-gen-api
docker push eduardoeli/pass-gen-front
```
## Deploy no Kubernets

Utilizamos o Kubernets para fazer o deploy das imagens.

Kinds Kubernets utilizados:
- deployment API
- deployment FRONT
- service API
- service FRONT
- ingress API
- ingress FRONT

Além disso toda configuração do projeto foi realizado na plataforma do kubernetes.


# Rodar Local
Com o Docker Desktop instalado é só ir na raiz do projeto, onde vai estar o arquivo docker-compose.yml e rodar o seguinte comando:

```bash
docker-compose up -d --build
```
## License
[LINK DEPLOY](https://front-gen.cloud.jacexperts.io/)
