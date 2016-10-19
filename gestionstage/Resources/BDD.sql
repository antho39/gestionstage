CREATE TABLE entreprises(
id SMALLINT UNSIGNED NOT NULL  AUTO_INCREMENT,
siret VARCHAR(14) NOT NULL,
nom VARCHAR(125) NOT NULL,
adresse VARCHAR(150) NOT NULL,
cp VARCHAR(5) NOT NULL,
ville VARCHAR(50) NOT NULL,
telephone VARCHAR(10),
email VARCHAR(50),
commentaire TEXT,
bool_envoye boolean,

PRIMARY KEY (id)
);

CREATE TABLE contrats(
id SMALLINT UNSIGNED NOT NULL  AUTO_INCREMENT,
bool_apprentissage boolean,
formation_id SMALLINT UNSIGNED NOT NULL,
s_nom VARCHAR(50) NOT NULL,
s_prenom VARCHAR(50) NOT NULL,
t_nom VARCHAR(50) NOT NULL,
t_prenom VARCHAR(50) NOT NULL,
t_mail VARCHAR(50) NOT NULL,
t_telephone VARCHAR(10) NOT NULL,
date_debut DATETIME NOT NULL,
date_fin DATETIME NOT NULL,
commentaire TEXT,
bool_envoye boolean,
appreciation SMALLINT UNSIGNED,
entreprise_id SMALLINT UNSIGNED NOT NULL,

PRIMARY KEY (id)
);

CREATE TABLE formations(
id SMALLINT UNSIGNED NOT NULL  AUTO_INCREMENT,
nom VARCHAR(50) NOT NULL,

PRIMARY KEY (id)
);


ALTER TABLE contrats ADD FOREIGN KEY (entreprise_id) REFERENCES entreprises(id);
ALTER TABLE contrats ADD FOREIGN KEY (formation_id) REFERENCES formations(id);
