# **VelibWeb**

## **Introduction**

VelibWeb est une application web qui nous propose un service de bike dans les ville different.

VelibWeb est IWS, VelibConsoleClient est une application de console, ce qui est la première minimal client.  WebFormClient est une application web avec nos extensions. Monitor est une application WinForm, ce qui nous propose d'évaluer les statistiques de données.

## **Fontionnalites**

Il existe deux parties dans ce projet, un web service intermédiaire qui propose un WS-SOAP API avec lequel le client peut accéder les services fournies.

IWS API possede 3 services:

1. GetHelp: le client peut récupérer les informations pour les usages de l'application
2. GetInfomationsOfStationByName: le client peut récupérer les informations   d'une station en donnant un nom d'une ville et le numéro d'une station
3. GetAllStationsByCity:  le client peut récupérer toutes les stations via le nom d'une ville

## **Extensions**

### **Asynchronous Access**

Parce que notre service utilise un autre service pour récupérer les données, donc c’est une manière appropriée d'implémenter des opérations de manière asynchrone. En cas d'implémentation asynchrone, nous pouvons utiliser un nouveau thread pour exécuter  la méthode, les threads actifs de notre serveur vont pas être bloqués.

### **Graphical User Interface**

Nous avons utilisé WebForm pour les interfaces. Ca nous permet d'implémenter GoogleMap facilement. En plus, nous avons également implémenté Boostrap pour la mise en page. Par exemple, nous avons utilisé GridLayout, Modal. Ca suffit d'implémenter les ressources

### **Cache management**

Afin de diminuer les communications entre Velib/Google Map et notre service web intermédiaire, nous avons ajouté les caches pour les stations, l’information d’une station et les chemins, qui va expirer après 40 min.

### **Functional extensions**

Les clients peuvent consulter les chemins d’une place/Velib station à une autre place/Velib station. Mais maintenant on n’offre que les chemins entre deux stations dans la même cité. Si besoin de consulter un chemin entre deux stations dans deux cités différentes, merci de copier les coordonnées de chaque station que vous pouvez trouver dans la page cityList.

Pour le client console, nous utilisons l'api de Google Map et affichons toutes les étapes. Comme Google Map offre l'interface graphique, le client WebForm communique avec Google Map directement en manière asynchrone (JavaScript dans la page).

### **Monitoring**

Pour le Monitoring, nous avons utilisé winForm pour le graphique simple.

Nous avons créé un service MonitorService, ce qui propose des opérations:

- GetDelay()
- GetCacheNumber()
- GetRequestFromClient()
- GetRequestToVelib()

Pour le stockage de données, nous avons créé une class MonitorStat. Chaque fois les clients font une request, le VelibService vont mettre à jours les données. Donc, dans le MonitorService, nous pouvons uniquement demander les données dans la class MonitorStat.

