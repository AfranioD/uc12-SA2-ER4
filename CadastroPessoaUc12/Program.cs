using CadastroPessoaUc12.Classes;

// PessoaFisica novaPf =new PessoaFisica();
// PessoaFisica metodosPf = new PessoaFisica();
// Endereco novoEndPf = new Endereco();

// novaPf.Nome = "Afranio Dimas";
// novaPf.dataNasc = new DateTime(2000, 01, 01);
// novaPf.Cpf = "1234567890";
// novaPf.Rendimento = 8500.5f;

// novoEndPf.Logradouro = "5th Avenue Park";
// novoEndPf.numero = 1485;
// novoEndPf.complemento = "5th on the Park";
// novoEndPf.endComercial = true;

// novaPf.Endereco = novoEndPf;

// Console.WriteLine(@$"
// Nome: {novaPf.Nome}
// Endereço: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.numero}
// Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}
// ");

// Console.WriteLine(novaPf.Nome);

// Console.WriteLine($"Nome: {novaPf.Nome}");

PessoaJuridica novaPj = new PessoaJuridica();
PessoaJuridica metodosPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.Nome = "Nome Pj";
novaPj.RazaoSocial = "Razão Social Pj";
novaPj.Cnpj = "00.000.000/0001-00";
novaPj.Rendimento = 12000.5f;

novoEndPj.Logradouro = "5th Avenue Park";
novoEndPj.numero = 1485;
novoEndPj.complemento = "5th on the Park";
novoEndPj.endComercial = true;

novaPj.Endereco = novoEndPj;

//Console.WriteLine(metodosPj.ValidarCnpj(novaPj.Cnpj));

Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Endereço: {novaPj.Endereco.Logradouro}, N°: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
");


