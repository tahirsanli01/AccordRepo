﻿// Accord Unit Tests
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2017
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace Accord.Tests.MachineLearning
{
    using Accord.IO;
    using Accord.MachineLearning.VectorMachines;
    using Accord.MachineLearning.VectorMachines.Learning;
    using Accord.Math;
    using Accord.Statistics;
    using Accord.Statistics.Analysis;
    using Accord.Statistics.Kernels;
    using Accord.Tests.MachineLearning.Properties;
    using NUnit.Framework;
    using System;
    using System.IO;
    using System.Text;
    using Math.Optimization.Losses;
    using Accord.Statistics.Models.Regression.Linear;

    [TestFixture]
    public class LiblinearTest
    {

        [Test]
        public void test_s0()
        {
            var train = prepare(0);

            LibSvmModel model = train.Model;
            Assert.AreEqual(LibSvmSolverType.L2RegularizedLogisticRegression, model.Solver);
            string str = model.Weights.ToCSharp();
            //#if DEBUG
            double[] expected_net = new double[] { -0.596401280670442, -1.31485791570613, -0.416499932170026, 0.179118395643096, 0.486909764466408, 0.46892840709615, 0.238078265612171, -0.152727895683988, 0.55372170917989, 0.660636166484261, 0.00669348732350971, -0.107105535594789, -0.337007373047201, -0.00188864648399806, -0.28193530336151, -0.0947029222474091, -0.107232110628385, -0.0630760051023019, -0.0494549393308846, -0.289514102609361, -0.0652486114411393, 0.173629057438153, -0.241477540991962, 0.566171534912423, 0.0303591173552118, -0.00125648689601715, -0.450893673586534, -0.39072926696445, 0.39357295084154, -0.0266092711442759, -0.202456480449632, -0.0319588882617886, 0.666577728600124, -0.332211718596713, -0.394355628876082, -1.23540364845551, -0.241477540991962, -0.0652486114411393, 0.0291026304591972, 0.916625889758896, 1.2327230857344, -0.624431970026704, -0.773222634779425, -0.710190059730589, -0.108616086128434, -0.401940517932262, 0.789276902192507, 0.72544321212095, 0.152615463415973, -0.637336052912087, 0.437025756222519, 0.842052697417264, 0.658782985107691, -0.598888229118347, -0.299548915919066, 0.15102531101201, -0.768808576155709, 0.0440484060205653, -0.472482373377613, 0.742563971729711, -0.114204831290008, 1.21449442598078, -0.877212394847502, -0.165446545859294, 0.04931915534648, -0.626966438061728, -0.190589483229222, 0.0723797425078125, 0.100502980374075, -0.346497069051671, -0.36509299750049, -0.0576939370002189, -0.702386606425341, 0.105985325754808, -1.10280990474959, 0.506408624079079, -0.852732579885193, 0.256331299214737, -1.04338305291236, -0.254167322590525, -0.0232570795760896, 0.282280994911964, 0.442125179496526, 0.280480008033217, 0.299426862084379, 0.133718390006117, -0.36510334903435, 0.456767126244601, 0.519856805967488, -0.163536379333567, -0.192070998953429, 0.393176458888595, -0.478057604128321, -0.375510629334053, -0.429947872952483, 0.279077974885294, 0.166812215923711, -0.0534701497052995, 0.600119500321023, 0.56504467122648, 0.0588890297922855, -0.082797498554715, -0.480565200907679, -0.391398157624915, 0.0352272258878802, 0.450371759529833, 0.391109215198408, -0.498813986927868, -0.0916081219595875, 0.0188475569389498, 0.127576369224342, 0.114516031288556, -0.693380265886907, 0.0110100696066839, -0.191865231360665, -0.100485118886502, -0.0393479255845686, -0.0487650442746711, 0.170950888490682, -0.244630360769844, -0.0847501908449253, -0.364693339476452, 0.0209843789716035, -0.00353173818235938 };
#if MONO
            double[] expected_mono = new double[] { -0.59784846104417744, -1.31476643577902, -0.416387471495486, 0.179220646633214, 0.487013112453937, 0.469032538606923, 0.238088957655237, -0.15271643160651, 0.553733674982517, 0.660645614360706, 0.00670313475813106, -0.107094463325938, -0.337003672044662, -0.00188858334877937, -0.281822604081863, -0.0946028000982446, -0.10713135403134, -0.0629761460238675, -0.0493547053451027, -0.289481646917302, -0.0651659257021417, 0.173651554397022, -0.241400684931642, 0.566202309342885, 0.0304114314672472, -0.00120526284938717, -0.450875133790372, -0.39070959880204, 0.393593666318316, -0.0265770851325789, -0.202447761215478, -0.0319356412705279, 0.66660481437524, -0.332199742083022, -0.394352902786683, -1.23527555923278, -0.241400684931642, -0.0651659257021417, 0.0292061686178611, 0.91674839166825, 1.23273370814014, -0.624328648625298, -0.773100886131257, -0.710093582780249, -0.108525723120664, -0.401855663693707, 0.789283186630566, 0.72544256301138, 0.152620381434645, -0.637333516786887, 0.437028816869646, 0.842054708675406, 0.658784336572128, -0.59888419657161, -0.299502830945717, 0.151024957660336, -0.768804093477891, 0.0440558851253734, -0.4724918532831, 0.742569266444511, -0.114207609948769, 1.21458766823199, -0.877191643097015, -0.165328019883736, 0.0493314458227605, -0.626710449553203, -0.190576611101226, 0.0725039843596424, 0.10059654590897, -0.346397691972144, -0.365012671897224, -0.0575777759797133, -0.702116552393963, 0.106228942813564, -1.10255113886301, 0.506663529282557, -0.852488052857277, 0.256600443276855, -1.04327791768064, -0.254067745410524, -0.0231510256589059, 0.282381612505178, 0.442227466664457, 0.280441718613271, 0.299422303178037, 0.133692583609993, -0.365121025318345, 0.456736897130311, 0.519825447020829, -0.163542402774299, -0.192081282781672, 0.39317081852226, -0.478073988172571, -0.37551646698047, -0.42995253676866, 0.27904916277104, 0.166791001832007, -0.0534735141651046, 0.600099202015335, 0.565020200011444, 0.0588640703977894, -0.082813808360576, -0.480571877463823, -0.391425022381544, 0.0352152143700193, 0.450352215965743, 0.391093162584344, -0.498823859937549, -0.0916142390997143, 0.0188335813282869, 0.127573098826612, 0.114502372702558, -0.69339641436798, 0.0109993932353496, -0.191877747830136, -0.100502385869024, -0.0393572307488391, -0.0487732623082484, 0.170941375351794, -0.244648900548538, -0.0847590072699711, -0.364706942588164, 0.0209796835559435 };
            Assert.IsTrue(model.Weights.IsEqual(expected_net, 5e-3)
                       || model.Weights.IsEqual(expected_mono, 5e-3));
#else
            Assert.IsTrue(model.Weights.IsEqual(expected_net, 5e-3));
#endif
            check(train, model);
        }

        [Test]
        public void test_s1()
        {
            var train = prepare(1);

            LibSvmModel model = train.Model;
            Assert.AreEqual(LibSvmSolverType.L2RegularizedL2LossSvcDual, model.Solver);
            // string str = model.Weights.ToCSharp();
            double[] expected = new double[] { -0.187002350839077, -0.372888673818314, -0.173357250924836, 0.0460061306863742, 0.159432235050686, 0.153805208167014, 0.102280655364794, -0.0399791292433845, 0.22887110689633, 0.249699503488536, 0.0145478303618283, -0.023883724996344, -0.449871257963284, 0, -0.0958590593405079, -0.0272292388805825, -0.033334768137011, -0.0173823549276472, -0.0131969295533334, -0.105180205573265, -0.0194718215279722, 0.085315958226414, -0.0859046378808536, 0.21043089145851, 0.0112064936060971, 0.00349206877157435, -0.108970664758944, -0.0997423577909522, 0.163203008994957, -0.0130443283659992, -0.0573780292106573, 0.00277802392862691, 0.245132553222642, -0.0908327191938414, -0.328036584745414, -0.433663364549813, -0.0859046378808536, -0.0194718215279722, 0.0146985623776712, 0.337338910741885, 0.368184238724315, -0.241895478441348, -0.267330264569461, -0.256214195052238, -0.072326089026487, -0.169882306963936, 0.452461744490078, 0.259321393457042, 0.0398475344105853, -0.184653976176208, 0.164098787141844, 0.306373565792976, 0.234268730131852, -0.202490944065139, -0.113615464557767, 0.0807820000188813, -0.280402909344066, -0.00479408170714506, -0.340275919151371, 0.274133229827586, -0.150926961870586, 0.381153555925809, -0.196795847822892, -0.0636900281416252, -0.0313036428203732, -0.203275792071456, -0.0730905959085381, 0.024278357530068, 0.0548212332914942, -0.130389802707576, -0.124779660013882, -0.0109324789391815, -0.221739138341446, 0.0347367875023654, -0.379836317286808, 0.19283396644772, -0.29283784131755, 0.105835490478467, -0.349478285940799, -0.076814900489791, -0.0121075470121231, 0.0970441396590154, 0.154354242944623, 0.10733004579722, 0.258817529621069, 0.08691176694377, -0.148671631787905, 0.238558848358923, 0.215938565641395, -0.209791248020613, -0.0811678661712386, 0.199816035240309, -0.34989098521102, -0.188994871017643, -0.197672501645266, 0.102161398092268, 0.0920984821714616, -0.0700726392792897, 0.224548403332015, 0.282920742042534, 0.0323108035772194, -0.0331970097274, -0.287892388521086, -0.0831699561226539, 0.12033750074312, 0.421368403976953, 0.29302432542685, -0.373886665293191, -0.0799840697019076, 0.06332981582091, 0.0808506496073297, 0.0820943265217946, -0.586678861595612, -0.0168931559449453, -0.100453547477385, -0.0969937132859026, -0.0775245667562146, -0.0508634252247505, 0.18550658652016, -0.101291607856744, -0.0545868086411493, -0.357727276179065, -0.00899044404008111, 0 };
            Assert.IsTrue(model.Weights.IsEqual(expected, 1e-10));
            check(train, model);
        }

        [Test]
        [Category("Slow")]
        public void test_s2()
        {
            var train = prepare(2);

            LibSvmModel model = train.Model;
            Assert.AreEqual(LibSvmSolverType.L2RegularizedL2LossSvc, model.Solver);
            string str = model.Weights.ToCSharp();
            //#if DEBUG
            double[] expected = new double[] { -0.187488643204109, -0.373136497040337, -0.168596301812443, 0.0451521813591027, 0.157154532897231, 0.151937441392535, 0.104843234216973, -0.0407496210011012, 0.230627674025567, 0.251448948904186, 0.0135428679089929, -0.02227322036464, -0.450015219699401, 1.55567658030135E-07, -0.0952819033820788, -0.0300774932724827, -0.0343337732410459, -0.0156920402206682, -0.0121034330877106, -0.106903401705997, -0.0181793655497043, 0.0853496931341161, -0.0868039864022859, 0.209832779335181, 0.0122401477633454, 0.00194323530710603, -0.111417438728785, -0.0969894151640031, 0.165850217966184, -0.0127391870484018, -0.0569999343345307, 0.00324607565297792, 0.243185323331783, -0.0890270787770432, -0.330076307983963, -0.430064188235043, -0.0868039864022859, -0.0181793655497043, 0.0141833830704617, 0.333375513912553, 0.366967735914914, -0.240073321212837, -0.269871250399526, -0.259150148036756, -0.0681802361966292, -0.168295007891941, 0.451113584618734, 0.260850594802921, 0.0365592239584133, -0.184725821022451, 0.164721216620745, 0.310051242456444, 0.236333432692522, -0.200080870448996, -0.115979073970556, 0.0803217030777578, -0.278875863241091, -0.00415381843091501, -0.340830028558683, 0.273195694522959, -0.149962968468448, 0.381974545217254, -0.197410873781337, -0.0655370867335718, -0.0313931719423322, -0.20674671693062, -0.0683753390334389, 0.0244039447956699, 0.0566754317405574, -0.130629134898303, -0.124681081753469, -0.0132578030884981, -0.219911872243387, 0.0324232290392954, -0.377134635298919, 0.18964599209494, -0.292652650651508, 0.105164007447436, -0.349429026170129, -0.0758627041764055, -0.0109266689154976, 0.0947919154889142, 0.153937840569, 0.107111789654718, 0.257897774071562, 0.0857333928025374, -0.146980660963761, 0.237451375255384, 0.212351028197568, -0.211457594949358, -0.0819757493882409, 0.199304913307405, -0.349739659624966, -0.190015573708603, -0.20216859674772, 0.102384502181668, 0.0909173081352463, -0.0685254780872241, 0.225005648134243, 0.284696897812626, 0.0309696439559705, -0.0341233048939117, -0.285523796575142, -0.0839428976156166, 0.119330850958298, 0.421711442694419, 0.293845599109487, -0.372609566010577, -0.0796039339198295, 0.0622752858389034, 0.0795779904821594, 0.0819649245653717, -0.587624329159858, -0.017941306571887, -0.101942218979906, -0.0961266251941682, -0.0787327889007127, -0.0503197252725044, 0.187890906555972, -0.099453269658236, -0.0576271277200639, -0.35885871690453, -0.00724823533973023, 2.80613693735061E-07 };
            //#else
            //            double[] expected = new double[] { -0.187488684683379, -0.373136487138834, -0.168596297827493, 0.0451521846830595, 0.157154535635041, 0.151937442367844, 0.104843216339796, -0.0407496404691985, 0.230627661950133, 0.251448927969665, 0.0135428465544977, -0.0222732365318683, -0.45001517816874, 1.18359959264837E-07, -0.0952818987910206, -0.0300774895097418, -0.0343337692522382, -0.0156920361762693, -0.0121034285510775, -0.106903403675511, -0.0181793619237928, 0.0853497076222055, -0.0868039821127823, 0.20983279079475, 0.0122401516611134, 0.0019432371412759, -0.111417430606487, -0.0969894135371026, 0.165850206643491, -0.0127391880660181, -0.0569998925382195, 0.00324608115445964, 0.243185324068444, -0.0890270290518889, -0.330076419854405, -0.430064190167946, -0.0868039821127823, -0.0181793619237928, 0.0141833888023809, 0.333375523121628, 0.366967727278737, -0.240073297162667, -0.269871229633974, -0.259150143545648, -0.0681802040735845, -0.168294996426294, 0.451113521282955, 0.260850592207594, 0.0365592298076514, -0.184725824270251, 0.164721222886, 0.310051246074565, 0.236333434359015, -0.20008087099189, -0.115979076249734, 0.0803217049947406, -0.278875862818475, -0.00415381064275821, -0.340830125196113, 0.273195700088985, -0.149962962605033, 0.381974569219595, -0.19741088793074, -0.0655370663375542, -0.0313931803316783, -0.206746704058553, -0.0683753528415963, 0.0244039493222803, 0.0566754286498214, -0.130629130866142, -0.12468107250134, -0.0132577968850348, -0.219911861224717, 0.032423238944097, -0.377134625488273, 0.189646003207757, -0.292652641026957, 0.105164018746521, -0.349429028990722, -0.0758626978823985, -0.0109266633784906, 0.0947919231011283, 0.153937844869923, 0.107111779163649, 0.257897794062107, 0.0857333608630217, -0.14698066784591, 0.237451344698826, 0.212351002622261, -0.211457780819405, -0.081975722103927, 0.199304907430013, -0.349739620147625, -0.190015597100508, -0.202168584601848, 0.102384508137795, 0.090917282924455, -0.0685260968157893, 0.225005654849588, 0.284696889782371, 0.0309696485382446, -0.0341233101589734, -0.285523826478739, -0.083942927459638, 0.119330816533167, 0.421711422706037, 0.293845614531373, -0.372609589321001, -0.0796039532633266, 0.0622752947768166, 0.0795780383249316, 0.0819649149261612, -0.587624370921401, -0.0179413154714611, -0.101942215921912, -0.0961266191331531, -0.078732798490904, -0.0503197271601607, 0.187890926560842, -0.09945328709214, -0.0576271350838896, -0.35885875658865, -0.00724823688139036 };
            //#endif
            Assert.IsTrue(model.Weights.IsEqual(expected, 1e-10));
            check(train, model);
        }

        [Test]
        public void test_s3()
        {
            var train = prepare(3);

            LibSvmModel model = train.Model;
            Assert.AreEqual(LibSvmSolverType.L2RegularizedL1LossSvcDual, model.Solver);
            // string str = model.Weights.ToCSharp();
            double[] expected = new double[] { -0.401629598520185, -0.773692686460867, -0.312335214627432, 0.106848014589882, 0.296745504093646, 0.280804783884593, 0.21021590349813, -0.101137961719607, 0.495334138592479, 0.477317757881286, 0.0657758292278433, -0.0651672937733189, -0.288411874610754, 0, -0.181019257723421, -0.0680152700236748, -0.0661676771714488, -0.0380062865518476, -0.0484211070497921, -0.129083523731551, -0.0735363957707153, 0.106819833694668, -0.236558408497104, 0.352491492414635, 0.0290482334017427, -0.0322153530423156, -0.244087074776336, -0.288411874610754, 0.107229023942626, 0.00308051893375935, 0.0421908594410488, -0.00790251872382717, 0.425534535239457, -0.167817071824762, -0.288411874610754, -0.740390697468092, -0.236558408497104, -0.0735363957707153, -0.0031671196405721, 0.652023022856298, 0.713663493859524, -0.416362049843629, -0.520583325833811, -0.378035368261245, -0.0335263941526525, -0.376226795521769, 0.609440841233395, 0.637217622238635, -0.0543349830534787, -0.396783151507348, 0.383083257789943, 0.722724047607922, 0.550617601506356, -0.327001175612184, -0.241745452425932, 0.185575222960543, -0.478821483978426, -0.132412425831108, -0.404669649893571, 0.500145178858346, -0.149668109563638, 0.826658732621267, -0.374766720805368, 0.0401701464755676, -0.0835455064778577, -0.619468889565957, -0.190677360767839, 0.0677256354134698, 0.093206559864874, -0.40031600645515, -0.22411586109885, 0.0618700737554764, -0.44142323440156, 0.0397936358813781, -0.817754699472699, 0.416125100952518, -0.607878191385389, 0.206248592865198, -0.765676341984267, -0.121518520859692, 0.0146734875332432, 0.205079297819953, 0.265812478970579, 0.201415806107914, 0.288411874610754, 0.153218673646929, -0.160453127113863, 0.588019337231132, 0.446009429789949, -2.77555756156289E-17, -0.157261230804335, 0.123914113655308, -0.576823749221507, -0.348510612465221, -0.288411874610753, 0.183444744474292, 0.169671275146074, -5.20417042793042E-18, 0.484516101138739, 0.330602734051802, 0.0424778472473847, -0.345954210465833, -0.576823749221508, -0.0537838457373276, 0.0287365977898098, 0.576979482790363, 0.61633825164591, -0.576823749221507, 0, 0.0398814950623403, 0.0151109587266906, 0.242846018917985, -0.746063286902218, 0.0235389972341098, -0.28201296387134, 1.38777878078145E-17, -0.0380071556910028, 0.0862240661884463, 0.134568555571055, -0.0444222025263786, -0.288411874610754, -0.296648036337198, 0.174431528417172, 0 };
            Assert.IsTrue(model.Weights.IsEqual(expected, 1e-10));
            check(train, model);
        }

        [Test]
        public void test_s6()
        {
            var train = prepare(6);

            LibSvmModel model = train.Model;
            Assert.AreEqual(LibSvmSolverType.L1RegularizedLogisticRegression, model.Solver);
            string str = model.Weights.ToCSharp();
            //#if DEBUG
            double[] expected = new double[] { -0.00193216355810173, -1.52731426685158, -0.599776711650451, -0.00319564089166846, 0.289527791149864, 0.272364988108588, 0.246704120354527, -0.129625236613622, 0.559784132997766, 0.665288912239086, 0.00082130247355937, -0.068685525408862, 0, 0, -0.184148089259529, -0.00303543635838481, -0.0129520891189136, 0.0144814543999521, 0.0304744789897905, -0.255252153444507, -0.00174662277901463, 0.209977934175585, -0.256132564072238, 0.563586870298957, 0.0072239412440491, 0, -0.23771432070953, -0.205558283623123, 0.397834193197151, 0, 0, 0, 0.664122274013464, 0, 0, -1.24531058191161, -0.106190729454989, -0.0018559838697592, 0.144472769418946, 1.00783329636676, 1.35202802007435, -0.423233984488684, -0.572197179894806, -0.496787925326737, 0, -0.12436408113766, 0.624902459817089, 0.659030417868679, 0.088965500604939, -0.681518377882409, 0.37301023405541, 0.782781914475685, 0.603519596026014, -0.631412190730473, -0.343158925421728, 0.0800638946866124, -0.824172381850303, 0, 0, 0.676962549507195, 0, 1.372607551119, -0.770481643706557, 0, 0.132198824325896, -0.475314987731171, -0.0741577066926857, 0.118463108590901, 0, -0.193221047885999, -0.245050084471318, 0, -0.80376848156524, 0, -1.61247672654214, 0, -1.11080844516924, 0, -1.03033583361617, -0.220817871657321, -0.00276707775003049, 0.291414096665174, 0.456261126214769, 0.239380035634766, 0, 0, -0.101248803601272, 0.259891352073587, 0.345707368384023, 0, 0, 0.095523716357443, 0, 0, -0.0998613789796218, 0, 0, 0, 0.59747953609938, 0.322817116322095, 0, 0, 0, -0.370867372403255, 0, 0, 0, 0, 0, 0, 0, 0, -0.32374708199723, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //#else
            //            double[] expected = new double[] { 0, -1.52411930888346, -0.596583111817898, 0, 0.292727759023382, 0.275575366462407, 0.24676095743599, -0.129572201230956, 0.559844892231062, 0.66534521821825, 0.000879164230483986, -0.0686330886172225, 0, 0, -0.181111397622509, 0, -0.00991428352063406, 0.0175209904561796, 0.0335134989297192, -0.255248789526732, -0.00176502791555098, 0.209984782120422, -0.367448607497345, 0.563593171185714, 0.00722090309758671, 0, -0.237718621468823, -0.205548471968789, 0.39784021510125, 0, 0, 0, 0.664127260363579, 0, 0, -1.25044015241842, 0, -0.00696263268540241, 0.13934699307474, 1.0027042612194, 1.37706274399545, -0.399190697412508, -0.548129185552888, -0.472742183132691, 0.0239080067826225, -0.100301587442094, 0.649939683214092, 0.659022287123922, 0.0889535736703365, -0.681529198102947, 0.372998740354973, 0.782770361970399, 0.603509699549445, -0.63141768284789, -0.343165978301099, 0.0800517084939236, -0.824178452698112, 0, 0, 0.67695344281223, 0, 1.37261423836496, -0.769604742726835, 0, 0.133193714506675, -0.474719179756764, -0.0731460851858957, 0.118470294170168, 0, -0.193218228858021, -0.24504663547359, 0, -0.803766963049391, 0, -1.6124656118763, 0, -1.11078701834284, 0, -1.05850565047486, -0.248995040148162, -0.0309462280753098, 0.263232619254183, 0.428081745732971, 0.239394878623662, 0, 0, -0.101230987414069, 0.259900887582786, 0.345724852074213, 0, 0, 0.0955162313021578, 0, 0, -0.0998563602922507, 0, 0, 0, 0.597462627643535, 0.32283415080533, 0, 0, 0, -0.370870419527936, 0, 0, 0, 0, 0, 0, 0, 0, -0.323785935489522, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //#endif
            Assert.IsTrue(model.Weights.IsEqual(expected, 1e-10));
            check(train, model);
        }

        [Test]
        public void test_s7()
        {
            var train = prepare(7);

            LibSvmModel model = train.Model;
            Assert.AreEqual(LibSvmSolverType.L2RegularizedLogisticRegressionDual, model.Solver);
            string str = model.Weights.ToCSharp();
            //#if DEBUG
            double[] expected = new double[] { -0.596401275873062, -1.31485792395839, -0.416499923663822, 0.179118388203961, 0.486909772391325, 0.468928411153847, 0.238078259399388, -0.152727905053675, 0.553721696250674, 0.660636167777458, 0.00669348742145133, -0.107105554516615, -0.337007377572817, -0.00188867186764809, -0.281935303045217, -0.0947029257730371, -0.107232114638211, -0.063075996923048, -0.0494549354935365, -0.289514103355529, -0.0652486049356425, 0.173629060362358, -0.241477538376927, 0.566171565985788, 0.0303591118572679, -0.00125648695317128, -0.450893615907307, -0.390729257485811, 0.393572944186189, -0.0266092742314279, -0.202456556404076, -0.0319588780655417, 0.666577705742126, -0.332211713834733, -0.394355634456621, -1.23540365160553, -0.241477538376927, -0.0652486049356425, 0.0291026249040985, 0.916625894140945, 1.2327230833333, -0.624431960581667, -0.773222635723864, -0.71019008205616, -0.108616068067666, -0.401940516618618, 0.789276903841592, 0.725443208865851, 0.152615469736007, -0.637336055593918, 0.437025752913847, 0.842052687779077, 0.658782980012451, -0.598888229906489, -0.299548907425015, 0.151025307473729, -0.768808580664615, 0.044048404783808, -0.472482370590795, 0.742563971093693, -0.114204864771794, 1.21449443726183, -0.877212358727085, -0.165446550913191, 0.0493191461877011, -0.626966441678619, -0.190589508003712, 0.0723797584301149, 0.100503011510427, -0.346497150768917, -0.365092976103956, -0.0576939189407263, -0.702386605791241, 0.105985329918206, -1.10280990569754, 0.506408629824496, -0.852732577884977, 0.256331302011899, -1.04338306379577, -0.254167320885895, -0.0232570709786294, 0.28228099121551, 0.442125188571717, 0.280480011434787, 0.299426850299548, 0.13371840738165, -0.365103308856029, 0.456767142431825, 0.51985682277694, -0.163536459772705, -0.192070947236374, 0.39317653941417, -0.478057633718926, -0.375510640197319, -0.429947843510385, 0.279077981895211, 0.166812302582923, -0.0534703601380505, 0.600119382273528, 0.565044679197678, 0.0588891183966146, -0.082797530551438, -0.480565246538663, -0.391398193095996, 0.0352272114666402, 0.450371749307927, 0.391109209285578, -0.498814001522533, -0.0916081231359386, 0.0188475474394981, 0.12757638262963, 0.114516022814428, -0.693380280253283, 0.0110100608978392, -0.191865240219761, -0.10048512479172, -0.0393479281107779, -0.0487650438947434, 0.17095088268044, -0.244630417954587, -0.084750201539472, -0.364693354669334, 0.0209843706352589, -0.00353177506398607 };
            //#else
            //            double[] expected = new double[] { -0.597848469338261, -1.31476644019452, -0.416387470604938, 0.179220650852893, 0.487013124973268, 0.469032537393794, 0.238088957385421, -0.152716452371581, 0.553733661405532, 0.660645619078619, 0.00670312414961433, -0.107094472934053, -0.337003662786201, -0.00188860888870906, -0.281822608450139, -0.0946027959759618, -0.107131343293526, -0.0629761494597794, -0.0493547004001313, -0.289481638490282, -0.0651659296570571, 0.17365155525784, -0.241400678104433, 0.56620232517615, 0.0304114404207007, -0.00120526863903704, -0.450875078330597, -0.390709579932595, 0.393593657513665, -0.0265770918266306, -0.202447837279295, -0.0319356265470529, 0.666604799768433, -0.332199738104867, -0.394352908804489, -1.23527555622739, -0.241400678104433, -0.0651659296570571, 0.0292061717816633, 0.916748394627684, 1.23273369863108, -0.624328629535498, -0.773100895115024, -0.710093596679699, -0.108525702171079, -0.40185566732812, 0.789283194618851, 0.725442560653851, 0.152620376532732, -0.637333522851759, 0.437028815502581, 0.842054697881785, 0.658784343445733, -0.598884189507711, -0.299502823363561, 0.151024959687836, -0.768804089986052, 0.0440558940864607, -0.47249185497526, 0.742569254132698, -0.114207647311995, 1.21458768081446, -0.877191608695873, -0.165328018736075, 0.0493314409875202, -0.626710456510399, -0.190576635439177, 0.0725039961703489, 0.100596579308022, -0.346397777372668, -0.365012643258376, -0.0575777524268608, -0.702116546937175, 0.106228949357641, -1.10255114041019, 0.506663542830631, -0.852488040736177, 0.256600443156653, -1.04327791872423, -0.254067733129423, -0.0231510322982821, 0.282381615964117, 0.442227470608279, 0.280441694715376, 0.299422294187851, 0.133692584509014, -0.36512098773348, 0.456736907489947, 0.519825458975261, -0.163542483248119, -0.192081223886317, 0.393170894866689, -0.478074022023571, -0.375516476807325, -0.429952510529078, 0.279049175795689, 0.166791076854825, -0.0534737277066511, 0.600099084742385, 0.565020203740183, 0.0588641475418749, -0.0828138424187361, -0.480571934742515, -0.391425053716063, 0.0352151979527091, 0.450352213717846, 0.391093161533462, -0.498823870992035, -0.0916142351450396, 0.0188335779130783, 0.127573110767404, 0.114502359453364, -0.693396428588785, 0.0109993846080798, -0.191877758799379, -0.100502393700181, -0.0393572245799602, -0.0487732726627187, 0.170941369632438, -0.244648963145269, -0.0847590112041392, -0.364706947920612, 0.0209796819210889 };
            //#endif
            Assert.IsTrue(model.Weights.IsEqual(expected, 1e-10));
            check(train, model);
        }

        private static Liblinear.Train prepare(int mode)
        {
            Accord.Math.Random.Generator.Seed = 0;
            Liblinear.Train train = new Liblinear.Train();
            train.Main("-s", mode.ToString(), "-c", "4.0", "-e", "1e-06",
                Path.Combine(TestContext.CurrentContext.TestDirectory, "Resources", "liblinear", "a9a.train"), 
                "result.txt");
            return train;
        }

        private static void check(Liblinear.Train train, LibSvmModel model)
        {
            var svm = train.Machine;
            //Assert.IsTrue(svm.SupportVectors.Length > 1);

            svm.Compress();

            Assert.AreEqual(svm.Threshold, model.Weights[0]);
            Assert.AreEqual(svm.SupportVectors.Length, 1);
            double[] expected = model.Weights.Get(1, 0);
            double[] actual = svm.SupportVectors[0].ToDense(model.Dimension);
            if (expected.Length < actual.Length)
                expected = Vector.Create(actual.Length, expected);
            Assert.IsTrue(expected.IsEqual(actual, 1e-10));
        }
    }
}
