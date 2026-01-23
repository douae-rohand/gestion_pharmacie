# Gestion de Pharmacie 💊

Un système complet de gestion de pharmacie développé en C# WinForms, permettant de gérer les stocks de médicaments, les clients, les commandes et les fournisseurs avec une intégration SQL Server.

## 🌟 Fonctionnalités Clés

### 📦 Gestion des Stocks (Médicaments)
- **Catalogue Complet** : Suivi des médicaments avec références, descriptions, photos et catégories.
- **Suivi des Stocks** : Visualisation en temps réel des quantités disponibles.
- **Alertes de Stock** : Système d'alerte automatique lorsque le stock atteint un seuil critique.
- **Gestion des Péremptions** : Suivi rigoureux des dates de péremption avec indicateurs de proximité.
- **Gestion des Prix** : Contrôle des prix d'achat et de vente avec calcul automatique des marges.

### 👥 Gestion des Clients
- **Base de Données Clients** : Enregistrement des informations personnelles (CIN, Téléphone, Adresse).
- **Historique d'Achats** : Suivi détaillé des commandes passées par chaque client.
- **Statistiques Clients** : Analyse des clients les plus actifs et calcul du revenu par client.

### 🧾 Gestion des Commandes
- **Prise de Commande** : Interface intuitive pour ajouter des produits à une commande.
- **Lignes de Commande** : Gestion détaillée des articles, quantités et prix unitaires.
- **Mise à jour Automatique** : Décrémentation automatique du stock lors de la validation d'une commande.
- **Statuts des Commandes** : Suivi des étapes (En cours, Validée, Livrée, Annulée).
- **Facturation** : Génération automatique de factures pour chaque commande.

### 🏢 Gestion des Fournisseurs
- **Annuaire Fournisseurs** : Gestion des coordonnées des fournisseurs.
- **Relations Fournitures** : Suivi de quel fournisseur fournit quel médicament avec le prix d'achat associé.

### 📊 Dashboard & Statistiques
- Vue d'ensemble des performances de la pharmacie.
- Statistiques sur le stock total, les alertes de péremption, et le chiffre d'affaires.

## 🛠️ Technologies Utilisées

- **Langage** : C#
- **Interface** : Windows Forms (WinForms)
- **Base de Données** : Microsoft SQL Server
- **Accès aux Données** : ADO.NET (Microsoft.Data.SqlClient)
- **Framework** : .NET Framework / .NET Core

## 📂 Structure du Projet

```text
gestion_pharmacie/
├── Medicament.cs       # Logique métier et accès DB pour les médicaments
├── Client.cs           # Logique métier et accès DB pour les clients
├── Commande.cs         # Gestion des commandes et des lignes de commande
├── Fournisseur.cs      # Gestion des fournisseurs
├── Program.cs          # Point d'entrée de l'application
├── Forms/              # Toutes les interfaces utilisateur (Designer.cs, .cs, .resx)
│   ├── FormAjouterMedicament.cs
│   ├── FormAjouterCommandes.cs
│   ├── FormListeCommandes.cs
│   └── ...
└── Resources/          # Images et icônes
```

## 🚀 Installation et Configuration

### Prérequis
- Visual Studio 2022 ou ultérieur.
- SQL Server LocalDB ou SQL Server Express.
- .NET SDK correspondant au projet.

### Configuration de la Base de Données
1. Créez une base de données nommée `Pharmacie` dans votre instance SQL Server.
2. Exécutez le script SQL (si disponible) ou laissez l'application créer les tables (vérifiez la logique d'initialisation).
3. **Important** : Modifiez la chaîne de connexion dans les fichiers `Medicament.cs`, `Client.cs`, et `Commande.cs` pour qu'elle pointe vers votre serveur :
   ```csharp
   private static string connectionString = "data source=VOTRE_SERVEUR;initial catalog=Pharmacie;integrated security=SSPI;...";
   ```

### Lancement
1. Ouvrez le fichier `gestion_pharmacie.sln` dans Visual Studio.
2. Restaurez les packages NuGet (si nécessaire).
3. Compilez et lancez l'application (F5).

## 📝 Licence
Ce projet est destiné à un usage éducatif/professionnel interne.

---
*Réalisé avec ❤️ pour une gestion pharmaceutique simplifiée.*
