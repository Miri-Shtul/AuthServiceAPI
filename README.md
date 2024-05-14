# AuthServiceAPI

A .NET 8 Web API for authentication and authorization using JWT tokens, with Swagger for API documentation and testing.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Configuration](#configuration)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Testing with Swagger](#testing-with-swagger)
- [Contributing](#contributing)
- [License](#license)

## Introduction

AuthServiceAPI is a robust authentication and authorization service built with .NET 8. It utilizes JWT (JSON Web Tokens) for secure access and provides Swagger UI for easy testing and documentation. This project demonstrates best practices in secure API development and token-based authentication.

## Features

- JWT token-based authentication
- Secure user login endpoint
- Protected endpoints accessible with valid JWT tokens
- Swagger UI for API testing and documentation
- User secrets for secure configuration management

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or any other preferred IDE
- [Git](https://git-scm.com/)
- [Postman](https://www.postman.com/) (optional, for API testing)

## Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/your-username/AuthServiceAPI.git
    cd AuthServiceAPI
    ```

2. Restore the dependencies:

    ```bash
    dotnet restore
    ```

3. Build the project:

    ```bash
    dotnet build
    ```

## Configuration

### Securely Storing the Secret Key

1. Initialize user secrets:

    ```bash
    dotnet user-secrets init
    ```

2. Set the secret key:

    ```bash
    dotnet user-secrets set "JwtSettings:Secret" "this_is_a_very_long_secret_key_12345!"
    ```

### Configuration in `Program.cs`

Ensure that the `Program.cs` file retrieves the secret key from user secrets as shown in the provided code.

## Usage

1. Run the application:

    ```bash
    dotnet run
    ```

2. Navigate to `https://localhost:<port>/swagger` in your browser to access the Swagger UI.

## API Endpoints

### Authentication Endpoints

- **POST /api/Auth/login**: Authenticates a user and returns a JWT token.

    Request body:
    ```json
    {
      "username": "string",
      "password": "string"
    }
    ```

    Response:
    ```json
    {
      "token": "string"
    }
    ```

### Protected Endpoints

- **GET /api/Protected**: Returns a message indicating the endpoint is protected.

    Response:
    ```json
    "This is a protected endpoint"
    ```

## Testing with Swagger

1. **Login**:
    - Go to the `Auth` section and expand the `POST /api/Auth/login` endpoint.
    - Click "Try it out" and enter the login details.
    - Execute the request and copy the JWT token from the response.

2. **Authorize**:
    - Click the "Authorize" button at the top right of the Swagger UI.
    - Enter the token in the format `Bearer <your_jwt_token>`.
    - Click "Authorize" to authorize.

3. **Access Protected Endpoint**:
    - Go to the `Protected` section and expand the `GET /api/Protected` endpoint.
    - Click "Try it out" and execute the request.
    - You should receive a response indicating the endpoint is protected.

## Contributing

Contributions are welcome! Please fork the repository and use a feature branch. Pull requests are accepted.

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (`git commit -m 'Add some feature'`).
5. Push to the branch (`git push origin feature-branch`).
6. Create a new Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
